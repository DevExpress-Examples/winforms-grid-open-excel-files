<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128630546/12.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4104)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Data Grid for Windows Forms - How to open Excel files in Grid Control

This example demonstrates how you can open Excel files in a [Grid Control](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl) in versions prior to v15.2.

The code uses the Microsoft OLE DB Provider for Microsoft Jet to populate a [DataSet](https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset) with data from an XLS file. This DataSet it then bound to the grid control.

<!-- default file list -->
## Files to Look At

* [ExcelDataBaseHelper.cs](./CS/ExcelDataBaseHelper.cs) (VB: [ExcelDataBaseHelper.vb](./VB/ExcelDataBaseHelper.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

## See Also
- [Microsoft OLE DB Provider for Microsoft Jet](http://msdn.microsoft.com/en-us/library/windows/desktop/ms681754(v=vs.85).aspx)
- [Import Excel File to DataSet - CodeProject](http://www.codeproject.com/Articles/32370/Import-Excel-File-to-DataSet)
