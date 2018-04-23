Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
			gridControl1.DataSource = ExcelDataBaseHelper.OpenFile("test.xls")
		End Sub
	End Class
End Namespace
