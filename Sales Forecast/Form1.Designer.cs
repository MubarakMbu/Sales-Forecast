namespace Sales_Forecast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LblTask = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNote = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.LblState = new System.Windows.Forms.Label();
            this.ChkState = new System.Windows.Forms.CheckBox();
            this.LblIncrease = new System.Windows.Forms.Label();
            this.BtnResult = new System.Windows.Forms.Button();
            this.PnlData = new System.Windows.Forms.Panel();
            this.ChtData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnSwitch = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnExport = new System.Windows.Forms.Button();
            this.TxtIncrease = new System.Windows.Forms.TextBox();
            this.CboTask = new System.Windows.Forms.ComboBox();
            this.CboYear = new System.Windows.Forms.ComboBox();
            this.DgvStates = new System.Windows.Forms.DataGridView();
            this.BtnStates = new System.Windows.Forms.Button();
            this.GrpPercent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStates)).BeginInit();
            this.GrpPercent.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTask
            // 
            this.LblTask.AutoSize = true;
            this.LblTask.Location = new System.Drawing.Point(324, 65);
            this.LblTask.Name = "LblTask";
            this.LblTask.Size = new System.Drawing.Size(37, 13);
            this.LblTask.TabIndex = 0;
            this.LblTask.Text = "Task :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Forecast";
            // 
            // LblNote
            // 
            this.LblNote.AutoSize = true;
            this.LblNote.Location = new System.Drawing.Point(324, 99);
            this.LblNote.Name = "LblNote";
            this.LblNote.Size = new System.Drawing.Size(263, 13);
            this.LblNote.TabIndex = 3;
            this.LblNote.Text = "Please select below inputs and click on Result Button.";
            // 
            // LblYear
            // 
            this.LblYear.AutoSize = true;
            this.LblYear.Location = new System.Drawing.Point(355, 134);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(35, 13);
            this.LblYear.TabIndex = 4;
            this.LblYear.Text = "Year :";
            // 
            // LblState
            // 
            this.LblState.AutoSize = true;
            this.LblState.Location = new System.Drawing.Point(355, 166);
            this.LblState.Name = "LblState";
            this.LblState.Size = new System.Drawing.Size(78, 13);
            this.LblState.TabIndex = 6;
            this.LblState.Text = "Data by State :";
            // 
            // ChkState
            // 
            this.ChkState.AutoSize = true;
            this.ChkState.Location = new System.Drawing.Point(462, 166);
            this.ChkState.Name = "ChkState";
            this.ChkState.Size = new System.Drawing.Size(15, 14);
            this.ChkState.TabIndex = 7;
            this.ChkState.UseVisualStyleBackColor = true;
            this.ChkState.CheckedChanged += new System.EventHandler(this.ChkState_CheckedChanged);
            // 
            // LblIncrease
            // 
            this.LblIncrease.AutoSize = true;
            this.LblIncrease.Location = new System.Drawing.Point(355, 189);
            this.LblIncrease.Name = "LblIncrease";
            this.LblIncrease.Size = new System.Drawing.Size(94, 13);
            this.LblIncrease.TabIndex = 8;
            this.LblIncrease.Text = "Percent Increase :";
            this.LblIncrease.Visible = false;
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(462, 215);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(75, 23);
            this.BtnResult.TabIndex = 11;
            this.BtnResult.Text = "Result";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // PnlData
            // 
            this.PnlData.Controls.Add(this.ChtData);
            this.PnlData.Controls.Add(this.DgvData);
            this.PnlData.Controls.Add(this.BtnSwitch);
            this.PnlData.Controls.Add(this.BtnCancel);
            this.PnlData.Controls.Add(this.BtnExport);
            this.PnlData.Location = new System.Drawing.Point(89, 244);
            this.PnlData.Name = "PnlData";
            this.PnlData.Size = new System.Drawing.Size(865, 328);
            this.PnlData.TabIndex = 12;
            this.PnlData.Visible = false;
            // 
            // ChtData
            // 
            chartArea4.Name = "ChartArea1";
            this.ChtData.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ChtData.Legends.Add(legend4);
            this.ChtData.Location = new System.Drawing.Point(18, 12);
            this.ChtData.Name = "ChtData";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ChtData.Series.Add(series4);
            this.ChtData.Size = new System.Drawing.Size(809, 261);
            this.ChtData.TabIndex = 6;
            this.ChtData.Text = "chart1";
            this.ChtData.Visible = false;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(197, 12);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.Size = new System.Drawing.Size(478, 267);
            this.DgvData.TabIndex = 5;
            // 
            // BtnSwitch
            // 
            this.BtnSwitch.Location = new System.Drawing.Point(373, 288);
            this.BtnSwitch.Name = "BtnSwitch";
            this.BtnSwitch.Size = new System.Drawing.Size(75, 23);
            this.BtnSwitch.TabIndex = 4;
            this.BtnSwitch.Text = "Chart";
            this.BtnSwitch.UseVisualStyleBackColor = true;
            this.BtnSwitch.Click += new System.EventHandler(this.BtnSwitch_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(468, 288);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnExport
            // 
            this.BtnExport.Location = new System.Drawing.Point(271, 288);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(89, 23);
            this.BtnExport.TabIndex = 1;
            this.BtnExport.Text = "Export Data";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // TxtIncrease
            // 
            this.TxtIncrease.Location = new System.Drawing.Point(462, 189);
            this.TxtIncrease.Name = "TxtIncrease";
            this.TxtIncrease.Size = new System.Drawing.Size(100, 20);
            this.TxtIncrease.TabIndex = 14;
            this.TxtIncrease.Text = "0";
            this.TxtIncrease.Visible = false;
            // 
            // CboTask
            // 
            this.CboTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTask.FormattingEnabled = true;
            this.CboTask.Location = new System.Drawing.Point(376, 62);
            this.CboTask.Name = "CboTask";
            this.CboTask.Size = new System.Drawing.Size(121, 21);
            this.CboTask.TabIndex = 15;
            this.CboTask.SelectedIndexChanged += new System.EventHandler(this.CboTask_SelectedIndexChanged);
            // 
            // CboYear
            // 
            this.CboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboYear.FormattingEnabled = true;
            this.CboYear.Location = new System.Drawing.Point(462, 134);
            this.CboYear.Name = "CboYear";
            this.CboYear.Size = new System.Drawing.Size(121, 21);
            this.CboYear.TabIndex = 16;
            // 
            // DgvStates
            // 
            this.DgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvStates.Location = new System.Drawing.Point(6, 51);
            this.DgvStates.Name = "DgvStates";
            this.DgvStates.Size = new System.Drawing.Size(293, 321);
            this.DgvStates.TabIndex = 0;
            // 
            // BtnStates
            // 
            this.BtnStates.Location = new System.Drawing.Point(135, 378);
            this.BtnStates.Name = "BtnStates";
            this.BtnStates.Size = new System.Drawing.Size(75, 24);
            this.BtnStates.TabIndex = 1;
            this.BtnStates.Text = "OK";
            this.BtnStates.UseVisualStyleBackColor = true;
            this.BtnStates.Click += new System.EventHandler(this.BtnStates_Click);
            // 
            // GrpPercent
            // 
            this.GrpPercent.Controls.Add(this.label2);
            this.GrpPercent.Controls.Add(this.BtnStates);
            this.GrpPercent.Controls.Add(this.DgvStates);
            this.GrpPercent.Location = new System.Drawing.Point(327, 118);
            this.GrpPercent.Name = "GrpPercent";
            this.GrpPercent.Size = new System.Drawing.Size(305, 408);
            this.GrpPercent.TabIndex = 17;
            this.GrpPercent.TabStop = false;
            this.GrpPercent.Text = "States Selection";
            this.GrpPercent.Visible = false;
            this.GrpPercent.VisibleChanged += new System.EventHandler(this.GrpPercent_VisibleChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report will be prepared for below states. Please delete not required rows.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 595);
            this.Controls.Add(this.GrpPercent);
            this.Controls.Add(this.CboYear);
            this.Controls.Add(this.CboTask);
            this.Controls.Add(this.TxtIncrease);
            this.Controls.Add(this.PnlData);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.LblIncrease);
            this.Controls.Add(this.ChkState);
            this.Controls.Add(this.LblState);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblTask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChtData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvStates)).EndInit();
            this.GrpPercent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNote;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.Label LblState;
        private System.Windows.Forms.CheckBox ChkState;
        private System.Windows.Forms.Label LblIncrease;
        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.Panel PnlData;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnSwitch;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtIncrease;
        private System.Windows.Forms.ComboBox CboTask;
        private System.Windows.Forms.ComboBox CboYear;
        private System.Windows.Forms.DataGridView DgvStates;
        private System.Windows.Forms.Button BtnStates;
        private System.Windows.Forms.GroupBox GrpPercent;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtData;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Label label2;
    }
}

