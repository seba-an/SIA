using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace utemAppWF
{
    public class DataSaving
    {
        string ConnStr = @"Data Source = C:\sisLabUtem.db ; Version = 3";

        //esto esta incompleto

        public void agregarAsignacion(ComboBox cBox1, ComboBox cBox2, ComboBox cBox3, string IDlab, string IDprof)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    string Query = $"select id_laboratorio, id_seccion from Laboratorio, Seccion" +
                        $" insert into Asignacion(cod_laboratorio,cod_secc,dia)  values(@cod_laboratorio, @cod_secc, @dia)";
                    SQLiteCommand cmd = new SQLiteCommand(Query, Conn);
                    Conn.Open();
                    cmd.Parameters.AddWithValue("@cod_laboratorio", IDlab);
                    cmd.Parameters.AddWithValue("@cod_secc", IDprof);
                    cmd.Parameters.AddWithValue("@dia", cBox3.Text);
                    int k = cmd.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("La asignación ha sido exitosa!");
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido asignar!");
                    }
                } 
                catch(Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

    }
}
