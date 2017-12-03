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
    public class DataAccess 
    {

        string ConnStr = @"Data Source = C:\bddUtemLab.db ; Version = 3"; 
        
        //metodo para llenar los combobox con los datos de la bdd 

        public void BindComboBox(ComboBox comboBoxName, string Query, string columnName, string tableName, string ID)
        {
            using(SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    SQLiteDataAdapter dAdapter = new SQLiteDataAdapter(Query, Conn);
         
                    Conn.Open();
                    DataSet dSet = new DataSet();
                    dAdapter.Fill(dSet, tableName); 
                    comboBoxName.DisplayMember = columnName;
                    comboBoxName.ValueMember = ID;
                    comboBoxName.DataSource = dSet.Tables[tableName];
                    Conn.Close();
                }  
                catch(Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            }

        } 

        //metodo para llenar el textbox "capacidad" en funcion del laboratorio escogido

        public void fetchTextBox(ComboBox comboBoxName, TextBox textBoxName, string Query, string columnName, string tableName, string ID)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    SQLiteCommand Cmd = new SQLiteCommand(Query, Conn);
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    SQLiteDataReader myReader;
                    myReader = Cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        string capacidad = (string)myReader[columnName].ToString();
                        textBoxName.Text = capacidad; 

                    }
                    Conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            } 
        } 

        public void disponibilidadTextBox(ComboBox comboBoxName, TextBox textBoxName, string Query, string columnName, string tableName, string ID)
        {

            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
            {
                try
                {
                    SQLiteCommand Cmd = new SQLiteCommand(Query, Conn);
                    Conn.Open();
                    Cmd.ExecuteNonQuery();
                    SQLiteDataReader myReader;
                    myReader = Cmd.ExecuteReader();

                    while (myReader.Read())
                    {
                        string disponible = (string)myReader[columnName].ToString();

                        if (disponible == "1")
                        {
                            string pos = "Si";
                            textBoxName.Text = pos; 
                        }
                        else
                        {
                            string ne = "No";
                            textBoxName.Text = ne;
                        }

                    }
                    Conn.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            }

        }

    }


}
