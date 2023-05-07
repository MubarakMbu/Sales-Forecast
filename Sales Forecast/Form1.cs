using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.Security.Cryptography;

namespace Sales_Forecast
{
    public partial class Form1 : Form
    {
        //Below server and database is present in my local pc. if you want to run this program in your pc please change these to yours.
        static readonly string server = "DESKTOP-T2IFRUH";    
        static readonly string database = "Sales Data";
        
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private string connectionString = "Data Source=" + server + ";Initial Catalog="+ database +";Integrated Security=True";    
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }


        //Events
        private void Form1_Load(object sender, EventArgs e)
        {
            //Loading Tasks to Task combobox
            string[] tasks = { "Total Sales", "Forecast Sales" };
            CboTask.Items.AddRange(tasks);
            CboTask.SelectedIndex = 0;

            //Load years to year combobox
            CboYear.DataSource = ExecuteQuery_Dtbl("SELECT DISTINCT YEAR(OrderDate) As SalesYear FROM Orders Order By SalesYear");
            CboYear.DisplayMember = "SalesYear";
            CboYear.ValueMember = "SalesYear";

        }
        private void BtnResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (CboTask.SelectedItem.ToString() == "Total Sales" )
                {
                    TotalSales();
                }
                else if (CboTask.SelectedItem.ToString() == "Forecast Sales")
                {
                    ForecastSales();
                }

                //On Result Button click dispalay Grid as default.
                DgvData.Visible = true;
                ChtData.Visible = false;
                BtnExport.Visible = true;
                BtnSwitch.Text = "Chart";
                PnlData.Visible = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            PnlData.Visible = false;
        }

        private void BtnSwitch_Click(object sender, EventArgs e)
        {
            //Display Chart
            if (DgvData.Visible)
            {
                //Load Grid Date to Chart
                LoadChart();
                DgvData.Visible = false;
                ChtData.Visible = true;
                BtnExport.Visible = false;
                BtnSwitch.Text = "Grid";
            }
            else
            {
                DgvData.Visible = true;
                ChtData.Visible = false;
                BtnExport.Visible = true;
                BtnSwitch.Text = "Chart";
            }
        }

        

        private void CboTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load States Grid with State Names.
            LoadStatesGrid();

            //Display Input Feilds based on Task
            if (CboTask.SelectedItem.ToString() == "Forecast Sales")
            {
                //Dispaly Percentage Increase lable and textbox 
                LblIncrease.Visible = true;
                TxtIncrease.Visible = true;
            }
            else
            {
                //Hiding below controls as Not required for "Total Sales"
                LblIncrease.Visible = false;
                TxtIncrease.Visible = false;
            }
        }

        

        private void ChkState_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkState.Checked)
            {
                //Load States Grid and Display, Editable Grid.
                LoadStatesGrid();
                GrpPercent.Visible = true; 
                
               //For Statewise Report case Disable the Percent Increase Textbox as Statewise Data will be considered.
                TxtIncrease.Enabled = false;

            }
            else
            {
                GrpPercent.Visible = false;
                TxtIncrease.Enabled = true;
            }
           
        }

        private void BtnStates_Click(object sender, EventArgs e)
        {
            GrpPercent.Visible = false;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            int i = 2;
            string extension = ".csv";
            string fileName = CboTask.SelectedItem.ToString() + "_" + CboYear.SelectedValue.ToString();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";

            //Check file is already present if yes use different file name.
            if (File.Exists($"{filePath}{fileName}{extension}"))
            {
                while (File.Exists($"{filePath}{fileName} ({i}){extension}"))
                {
                    i ++;
                }
                filePath = $"{filePath}{fileName} ({i}){extension}";
            }
            else
            {
                filePath = $"{filePath}{fileName}{extension}";
            }

            //Export Data from Grid to Csv file and save file at passed path
            ExportDataToCsv(filePath);

            //Open the csv file
            Process.Start(filePath);
            MessageBox.Show($"The forecasted data has been exported to {filePath}.", "Export to CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
        private void GrpPercent_VisibleChanged(object sender, EventArgs e)
        {
            if (GrpPercent.Visible)
            {
                PnlData.Visible = false;

            }
        }


        //Own Methodes
        /// <summary>
        /// Take a query input and return datatable containing resultant data after query execution.
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        private DataTable ExecuteQuery_Dtbl(string query)
        {
            connection.Open();
            command = new SqlCommand(query, connection);
            if (query.Contains("@SelectedYear"))
            {
                int SelectedYear = (int)CboYear.SelectedValue; //get selected year.
                command.Parameters.AddWithValue("@SelectedYear", SelectedYear);
            }

            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        /// <summary>
        /// 
        /// </summary>
        private void TotalSales()
        {
            if (ChkState.Checked)
            {
                DataTable serverDtbl = ExecuteQuery_Dtbl("SELECT Orders.State AS State, SUM(Sales) AS Sales FROM Products INNER JOIN Orders ON Products.OrderId = Orders.OrderId LEFT JOIN OrdersReturns ON Orders.OrderId = OrdersReturns.OrderId WHERE Year(Orders.OrderDate) = @SelectedYear AND OrdersReturns.OrderId IS NULL GROUP BY Orders.State ORDER BY Orders.State");
                
                //Reset DataTable and create columns for Forecast Report.
                dataTable = new DataTable();
                dataTable.Columns.Add("State", typeof(String));
                dataTable.Columns.Add("Sales", typeof(double));

                for(int i= 0;  i < DgvStates.Rows.Count-1; i++)
                {
                    //Take state from States Grid
                    string state = DgvStates.Rows[i].Cells["State"].Value.ToString();

                    //Take Sales vale for above State from Server
                    double sales =(double) serverDtbl.Select("State = '" + state + "'")[0]["Sales"];
                   
                    dataTable.Rows.Add(state, sales);
                }
                

            }
            else
            {
                dataTable = ExecuteQuery_Dtbl("SELECT SUM(Sales) AS Sales FROM Products INNER JOIN Orders ON Products.OrderId = Orders.OrderId LEFT JOIN OrdersReturns ON Orders.OrderId = OrdersReturns.OrderId WHERE Year(Orders.OrderDate) = @SelectedYear AND OrdersReturns.OrderId IS NULL");
                
            }

            DgvData.DataSource = dataTable;
        }

        private void ForecastSales()
        {
            double sales;
            double foreCastSales;
            int percentInc = 0;

            //Check Sales value required by State or Total
            if (ChkState.Checked)
            {
                //Preparing Statewise Report
                
                //First load all States Data to Datatable to avoid querying server multiple times.
                DataTable Dtbl = ExecuteQuery_Dtbl("SELECT Orders.State AS State, SUM(Sales) AS Sales FROM Products INNER JOIN Orders ON Products.OrderId = Orders.OrderId LEFT JOIN OrdersReturns ON Orders.OrderId = OrdersReturns.OrderId WHERE Year(Orders.OrderDate) = @SelectedYear AND OrdersReturns.OrderId IS NULL GROUP BY Orders.State");

                //Reset DataTable and create columns for Forecast Report.
                dataTable = new DataTable();
                dataTable.Columns.Add("State", typeof(String));
                dataTable.Columns.Add("Sales", typeof(double));
                dataTable.Columns.Add("PercentageIncrease", typeof(int));
                dataTable.Columns.Add("ForecastSales", typeof(double));

                //Update Forecast sales report only for States present in Server Grid (user requirements)
                for (int i = 0; i < DgvStates.RowCount - 1; i++)
                {
                    //Take state from States Grid
                    string state = DgvStates.Rows[i].Cells["State"].Value.ToString();
                    
                    //Take Sales vale for above State from Server
                    DataRow[] dtrows = Dtbl.Select("State = '" + state + "'");
                    if (dtrows.Length > 0)
                    {
                        sales = (double)dtrows[0]["Sales"];
                    }
                    else
                    {
                        sales = 0;
                    }

                    //Take Percent Increase value from States Grid.
                    percentInc = (int)DgvStates.Rows[i].Cells["PercentageIncrease"].Value;
                    
                    //Total Increment Sales
                    foreCastSales = sales + (sales * percentInc / 100);
                    dataTable.Rows.Add(state, sales, percentInc, foreCastSales);
                }
            }
            else
            {
                //Total Report

                dataTable = ExecuteQuery_Dtbl("SELECT SUM(Sales) AS Sales FROM Products INNER JOIN Orders ON Products.OrderId = Orders.OrderId LEFT JOIN OrdersReturns ON Orders.OrderId = OrdersReturns.OrderId WHERE Year(Orders.OrderDate) = @SelectedYear AND OrdersReturns.OrderId IS NULL");

                int.TryParse(TxtIncrease.Text, out percentInc);
                sales = (double)dataTable.Rows[0]["Sales"];
                foreCastSales = sales + (sales * percentInc / 100);
                
                //Prepare Data tble.
                dataTable.Columns.Add("PercentageIncrease", typeof(int));
                dataTable.Columns.Add("ForecastSales", typeof(double));
                dataTable.Rows[0]["PercentageIncrease"] = percentInc;
                dataTable.Rows[0]["ForecastSales"] = foreCastSales;
            }
            DgvData.DataSource = dataTable;
        }

        private void LoadChart()
        {
            //Reset the Chart with new Grid Data
            ChtData.Series.Clear();
            ChtData.DataSource = DgvData.DataSource;

            //Create common Sales series present in both tasks.
            CreateSeries("Sales");

            //Create ForecastSales Series only of it's a Forecast Sales task.
            if (CboTask.SelectedItem.ToString() == "Forecast Sales")
            {
                CreateSeries("ForecastSales");
            }
        }

        private void CreateSeries(string seriesName)
        {
            Series series = new Series(seriesName);
            series.YValueMembers = seriesName;

            if (ChkState.Checked)
            {
                series.XValueMember = "State";
            }
            ChtData.Series.Add(series);
        }

        private void ExportDataToCsv(string filePath)
        {
            try
            {
                //Get Data from Result Grid.
                dataTable = (DataTable)DgvData.DataSource;

                // Open file for writing
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write Columns Names
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        writer.Write(column.ColumnName);
                        writer.Write(",");
                    }
                    writer.WriteLine();

                    // Write data rows
                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            writer.Write(item.ToString());
                            writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void LoadStatesGrid()
        {
            
            
            int percentIncrease = 0;
            int.TryParse(TxtIncrease.Text, out percentIncrease);

            //Load States list to Datagrid
            dataTable = ExecuteQuery_Dtbl("SELECT DISTINCT State FROM Orders Order By State");

            //Add PercentIncrease new column to Take Statewise Percent Increase from user.
            if (CboTask.SelectedItem.ToString() == "Forecast Sales")
            {
                // Create new Percent Increase Data Column to the DataTable.
                DataColumn dataColumn = new DataColumn("PercentageIncrease", typeof(int));
                dataTable.Columns.Add(dataColumn);

                // update the default value same as the value specified in Percent Increase textbox.
                dataTable.AsEnumerable().ToList().ForEach(row => row["PercentageIncrease"] = percentIncrease);
            }
            
            DgvStates.DataSource = dataTable;
        }

    }
}
