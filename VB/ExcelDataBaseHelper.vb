Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO
Imports System.Data.OleDb
Imports System.Data

Namespace WindowsApplication1
	Public Class ExcelDataBaseHelper
		Public Shared Function OpenFile(ByVal fileName As String) As Object
			Dim fullFileName = String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)
			If (Not File.Exists(fullFileName)) Then
				System.Windows.Forms.MessageBox.Show("File not found")
				Return Nothing
			End If
			Dim connectionString  As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fullFileName)
			Dim adapter = New OleDbDataAdapter("select * from [Sheet1$]", connectionString)
			Dim ds = New DataSet()
			Dim tableName As String = "excelData"
			adapter.Fill(ds, tableName)
			Dim data As DataTable = ds.Tables(tableName)
			Return data
		End Function

	End Class
End Namespace
