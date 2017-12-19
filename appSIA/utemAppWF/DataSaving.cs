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

        public void agregarAsignacion(ComboBox cBox1, ComboBox cBox2, ComboBox cBox3, string IDlab, string IDsecc)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                try
                {

                    string Query = $"select la.id_laboratorio, se.id_seccion from Laboratorio as la, Seccion as se" +
                        $" insert into Asignacion(cod_laboratorio,cod_secc,dia)  values(la.id_laboratorio, se.id_seccion, @dia)" +
                        $"where nombre se.asignatura = '"+ cBox1.SelectedItem  +"' and la.nombre = '" + cBox2.SelectedItem +"'";

                    SQLiteCommand cmd = new SQLiteCommand(Query, Conn);
                    Conn.Open(); 
                    
                    cmd.Parameters.AddWithValue("@cod_laboratorio", IDlab);
                    cmd.Parameters.AddWithValue("@cod_secc", IDsecc);
                    cmd.Parameters.AddWithValue("@dia", cBox3.SelectedItem.ToString());
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
