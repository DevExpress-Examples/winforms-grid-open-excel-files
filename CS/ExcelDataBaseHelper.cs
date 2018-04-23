using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Data;

namespace WindowsApplication1
{
    public class ExcelDataBaseHelper
    {
        public static object OpenFile(string fileName)
        {
            var fullFileName = string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), fileName);
            if (!File.Exists(fullFileName))
            {
                System.Windows.Forms.MessageBox.Show("File not found");
                return null;
            }
            var connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fullFileName);
            var adapter =  new OleDbDataAdapter("select * from [Sheet1$]", connectionString);
            var ds = new DataSet();
            string tableName = "excelData";
            adapter.Fill(ds, tableName);
            DataTable data = ds.Tables[tableName];
            return data;
        }
        
    }
}
