<!-- default file list -->
*Files to look at*:

* [ExcelDataBaseHelper.cs](./CS/ExcelDataBaseHelper.cs) (VB: [ExcelDataBaseHelper.vb](./VB/ExcelDataBaseHelper.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to open Excel files in GridControl


<p>Our GridControl, as well as any standard control, does not directly work with physical files. There are many reasons for this. For example, it is not possible to get notifications when some part of a physical file is changed. Thus, it will be necessary to reload the entire file each time the GridControl content needs to be refreshed. Also, to save each change made in GridControl, it will be necessary to access this file again. Thus, dealing with physical files directly will be very slow.</p>
<p>Starting with<strong> version 15.2, </strong><a href="https://documentation.devexpress.com/#CoreLibraries/clsDevExpressDataAccessExcelExcelDataSourcetopic">ExcelDataSource</a><strong> </strong>is available, which allows extracting data from Microsoft Excel workbooks or CSV files. For more information about it, please review the <a href="https://documentation.devexpress.com/WindowsForms/115529/Common-Features/Data-Binding/Binding-to-Excel-Data-Sources">Binding to Excel Data Sources</a> documentation topic.<br><br>If you are using<strong> an older version</strong>, you can populate a DataSet with data from an Excel file and then bind the grid control to this DataSet. To do this, you can use the Microsoft OLE DB Provider for Microsoft Jet. <br>These solutions are described in the following articles:</p>
<p><a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms681754(v=vs.85).aspx">Microsoft OLE DB Provider for Microsoft Jet</a></p>
<p><a href="http://www.codeproject.com/Articles/32370/Import-Excel-File-to-DataSet">Import Excel File to DataSet - CodeProject</a></p>
<p> </p>
<p>This example demonstrates this approach in action.</p>

<br/>


