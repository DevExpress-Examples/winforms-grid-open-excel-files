Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Imports DevExpress.XtraEditors

Namespace WindowsApplication1

    Public Class ExcelDataBaseHelper

        Public Shared Function OpenFile(ByVal fileName As String) As Object
            Dim fullFileName = String.Format("{0}\{1}", Directory.GetCurrentDirectory(), fileName)
            If Not File.Exists(fullFileName) Then
                XtraMessageBox.Show("File not found")
                Return Nothing
            End If

            Dim connectionString = String.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fullFileName)
            Using adapter = New OleDbDataAdapter("select * from [Sheet1$]", connectionString)
                Dim ds = New DataSet()
                Dim tableName As String = "excelData"
                adapter.Fill(ds, tableName)
                Dim data As DataTable = ds.Tables(tableName)
                Return data
            End Using
        End Function
    End Class
End Namespace
