# Sales Forecast

Database : SQL Server<br />
Programming Language : C#<br />
Front end framework : WinForms .net 4.7.2<br />

#How to Run the Programe?<br />
1)To clone this repository choose required path and run the below command in CLI.<br />
	git clone https://github.com/MubarakMbu/Sales-Forecast.git<br />
2) Create "Sales Data" database containing "Orders", "OrdersReturns" and "Products" tables in your loacal sql server (refer .sql files  present in the Cloned folder).<br />
3) Open "Sales Forecast.sln" file using visual Studio.<br />
4) Change the "server" variable of Form1 class with your loacal server name and build the solution.<br />
5)Now application is ready to run and use.<br />

#How to use the Software?<br />
The following taks can be performed using this software,<br />
1) Total Sales.<br />
2) Forecast Sales.<br />

1)Total Sales:<br />
	i)To get the total sales of particular year. Select the year from the list and click on the "Result" button.<br />
	ii)To get the total sales Statewise click on the "Data by State:" Checkbox,<br />
		A new Editable DataGrid containing List of all the States will be displayed.<br />
		Keep only required rows by deleting others and then click on ok button.<br />
	iii)Click on "Result" button to view the Result window.<br />

2) Forecast Sales:<br />
	i) As soon as you select this task a new textbox will be displayed to Enter Percentage Increase.<br />
	ii) After entering Percentage increase click on the "Result" button to get the Result window.<br />
	iii) To get statewise forecast data clickthe "Data by State:" Checkbox,<br />
       In this you will have one extra column to update different Percentage increase to different states.<br />
	iii)Click on "Result" button to view the Result window.<br />

Result window:<br />
	In Result window you have following buttons.<br />
	Chart: To see the result data in chart format then click on this button.<br />
	Export Data : To export the result data to csv file then click on this button.<br />
		      Exported file will be Saved in your desktop and opened automatically.<br />
  Cancel: To cancel the result window.<br />

