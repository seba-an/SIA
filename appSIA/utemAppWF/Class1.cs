using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace utemAppWF
{
    public class Class1
    {
        string ConnStr = @"Data Source = C:\sisLabUtem.db ; Version = 3";

        public void GetData(string Query, DataGrid dataGrid)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
                try
                {

                    SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Query, Conn);
                    Conn.Open();
                    DataTable table = new DataTable();
                    table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataAdapter.Fill(table);
                    dataGrid.DataSource = table;
                    Conn.Close();


                }
                catch (Exception)
                {
                    MessageBox.Show("Problema con la BDD");
                }
        }

    }
}
