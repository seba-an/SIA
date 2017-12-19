using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
//using Dapper;

namespace utemAppWF
{
    public class DataSaving
    {
        string ConnStr = @"Data Source = C:\sisLabUtem.db ; Version = 3";

        //esto esta incompleto

        public void agregarAsignacion(ComboBox cBox1, ComboBox cBox2, ComboBox cBox3)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                try
                {

                    string Query1 = $"insert into Asignacion [(id_asignacion, cod_laboratorio, cod_secc)] values(@idlab, @idsecc) " +
                        $"select la.id_laboratorio, la.nombre, se.id_seccion, se.asignatura from Laboratorio as la, Seccion as se " +
                        $"where se.asignatura = '" + cBox1.SelectedItem + "' and la.nombre = '" + cBox2.SelectedItem + "' ";
                    // Query2 = $"insert into Asignacion [(id_asignacion, cod_laboratorio, cod_secc)] values(la.id_laboratorio, se.id_seccion)";

                    //SQLiteCommand cmd2 = new SQLiteCommand(Query2, Conn);
                    Conn.Open();

                    SQLiteCommand cmd1 = new SQLiteCommand(Query1, Conn);
                    cmd1.ExecuteNonQuery();
                    /*
                    int k = cmd1.ExecuteNonQuery();
                    if (k > 0)
                    {
                        MessageBox.Show("La asignación ha sido exitosa!");
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido asignar!");
                    }*/
                } 
                catch(Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

    }
}
