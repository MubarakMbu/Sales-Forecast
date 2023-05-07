# Sales Forecast

Database : SQL Server
Programming Language : C#
Front end framework : WinForms .net 4.7.2

#How to Run the Programe?
1)To clone this repository choose required path and run the below command in CLI.
	git clone https://github.com/MubarakMbu/Sales-Forecast.git
2) Create "Sales Data" database containing "Orders", "OrdersReturns" and "Products" tables in your loacal sql server (refer .sql files  present in the Cloned folder).
3) Open "Sales Forecast.sln" file using visual Studio.
4) Change the "server" variable of Form1 class with your loacal server name and build the solution.
5)Now application is ready to run and use.

#How to use the Software?
The following taks can be performed using this software,
1) Total Sales.
2) Forecast Sales.

1)Total Sales:
	i)To get the total sales of particular year. Select the year from the list and click on the "Result" button.
	ii)To get the total sales Statewise click on the "Data by State:" Checkbox,
		A new Editable DataGrid containing List of all the States will be displayed.
		Keep only required rows by deleting others and then click on ok button.
	iii)Click on "Result" button to view the Result window.

2) Forecast Sales:
	i) As soon as you select this task a new textbox will be displayed to Enter Percentage Increase.
	ii) After entering Percentage increase click on the "Result" button to get the Result window.
	iii) To get statewise forecast data clickthe "Data by State:" Checkbox,
       In this you will have one extra column to update different Percentage increase to different states.
	iii)Click on "Result" button to view the Result window.

Result window:
	In Result window you have following buttons.
	Chart: To see the result data in chart format then click on this button.
	Export Data : To export the result data to csv file then click on this button.
		      Exported file will be Saved in your desktop and opened automatically.
  Cancel: To cancel the result window.

