using DevExpress.DataAccess.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            var source = new ExcelDataSource();
            source.FileName = "test.xls";
            var worksheetSettings = new ExcelWorksheetSettings("Sheet1", "A1:B3");
            source.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            source.Fill();
            gridControl1.DataSource = source;
        }
    }
}
