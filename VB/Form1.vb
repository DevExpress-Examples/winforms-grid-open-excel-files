Imports DevExpress.DataAccess.Excel
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim source = New ExcelDataSource()
            source.FileName = "test.xls"
            Dim worksheetSettings = New ExcelWorksheetSettings("Sheet1", "A1:B3")
            source.SourceOptions = New ExcelSourceOptions(worksheetSettings)
            source.Fill()
            gridControl1.DataSource = source
        End Sub
    End Class
End Namespace
