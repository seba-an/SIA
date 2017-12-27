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

        public void agregarAsignacion(ComboBox cBox, TextBox tBox, string IDsecc, string IDlab)/*, string tableName)*/
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                string Query = $" insert into Asignacion(cod_laboratorio,cod_secc) values(@cod_laboratorio, @cod_secc) select id_laboratorio, id_seccion from Laboratorio as la, Seccion as se where se.id_seccion == '" + cBox.Text + "' and la.id_laboratorio == '" + tBox.Text + "'";

                //cmd.Parameters.AddWithValue("@dia", cBox3.Text);
                /*SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(Query, Conn);
                DataSet dSet = new DataSet();
                dAdapter.Fill(dSet, tableName);
                */
                SQLiteCommand cmd = new SQLiteCommand(Query, Conn);
                //SQLiteDataReader rdr;
                //rdr = cmd.ExecuteReader();

                /*
                Int32.TryParse(cBox.Text, out idSe);
                Int32.TryParse(tBox.Text, out idLa);
                */

                int idSe = 0;
                int idLa = 0;

                cmd.Parameters.AddWithValue("@cod_secc", Int32.TryParse(cBox.Text, out idSe));//idSe);
                cmd.Parameters.AddWithValue("@cod_laboratorio", Int32.TryParse(tBox.Text, out idLa)); //idLa);
                   
                    //Conn.Close();

                try
                {
                    Conn.Open();
                    Int32 rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados satisfactoriamente!");
                    Conn.Close();
                 
                } 
                catch(Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }

    }
}
