Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            gridControl1.DataSource = ExcelDataBaseHelper.OpenFile("test.xls")
        End Sub
    End Class
End Namespace
