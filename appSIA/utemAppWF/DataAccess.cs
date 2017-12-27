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

        string ConnStr = @"Data Source = C:\sisLabUtem.db ; Version = 3";

        //metodo para llenar los combobox con los datos de la bdd 

        public void BindComboBox(ComboBox comboBoxName, string Query, string columnName, string tableName, string ID)
        {
            using (SQLiteConnection Conn = new SQLiteConnection(ConnStr))
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

                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            }
            comboBoxName.SelectedIndex = -1;

        }
        public void GetData(string Query, DataGridView dataGrid)
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


        //metodo para llenar el textbox "capacidad" en funcion del laboratorio escogido

        public void fetchTextBox(ComboBox comboBoxName, TextBox textBoxName, string Query, string columnName)
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

                        string cadena = (string)myReader[columnName].ToString();
                        textBoxName.Text = cadena;

                    }
                    Conn.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }

        }

        //metodo para llenar el textbox "disponibilidad" en funcion del laboratorio

        public void disponibilidadTextBox(ComboBox comboBoxName, TextBox textBoxName, string Query, string columnName)
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
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }

            }

        }

        //metodo para llenar los textbox "nombre" y "apellido" en funcion de la asignatura


        public void nombreCompletoTextbox(ComboBox comboBoxName, TextBox textBoxName, string Query, string columnName)
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
                        string cadena = (string)myReader[columnName].ToString();
                        textBoxName.Text = cadena;


                    }
                    Conn.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }

        }
        /*
        public void llenarHorario(string Hora, ComboBox comboBoxName, string Query, string tableName, string columnName, string ID1, string ID2, TextBox txtbx1, TextBox txtbx2, TextBox txtbx3, TextBox txtbx4, TextBox txtbx5, TextBox txtbx6)
        {
            TextBox[] cajas = new TextBox[] { txtbx1, txtbx2, txtbx3, txtbx4, txtbx5, txtbx6 };

            foreach (TextBox t in cajas)
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
                        string horaInicio = (string)myReader[columnName].ToString();
                        //.Text = horaInicio;
                        //string hora = "8:00:00";
                        if(string.ReferenceEquals(horaInicio, Hora))
                        {
                            string valor = "Asignado";
                            t.Text = valor;
                        }
                        else
                        {   
                            string valor1 = "Libre";
                            t.Text = valor1;
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
        }*/


    }
}