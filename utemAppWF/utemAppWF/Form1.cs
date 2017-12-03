using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;


namespace utemAppWF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            DataAccess da = new DataAccess();
           
            //parametros para el data binding de "profecombobox"

            string SQLiteQuery = $"select id_encargado, nombre from Encargado";
            string nombre = "nombre";
            string id = "id_encargado";
            string tabla = "Encargado";


            da.BindComboBox(ProfeCombobox, SQLiteQuery, nombre, tabla, id);
            
            //parametros para el data binding de "labcombobox"


            string sqlitequery = $"select id_laboratorio, nombre from Laboratorio";
            string campo = "nombre";
            string iD = "id_laboratorio";
            string table = "Laboratorio";

          

            da.BindComboBox(LabCombobox, sqlitequery, campo, table, iD);  


           
            

        }

        private void LabCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LabCombobox.SelectedItem != null)
            {
                DataRowView drv = LabCombobox.SelectedItem as DataRowView;

                Debug.WriteLine("item " + drv.Row["nombre"].ToString());
                Debug.WriteLine("Value " + drv.Row["id_laboratorio"].ToString());
                Debug.WriteLine("Value " + LabCombobox.SelectedValue.ToString());

                string query = $"select * from Laboratorio where nombre = '"+LabCombobox.Text+"'";
                string columna = "capacidad";
                string columna2 = "disponibilidad";
                string tabla = "Laboratorio";
                string cod = "id_laboratorio";

                DataAccess da2 = new DataAccess();

                da2.fetchTextBox(LabCombobox, capacidadTextbox, query, columna, tabla, cod);

                da2.disponibilidadTextBox(LabCombobox, dispoTextBox, query, columna2, tabla, cod);
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProfeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ProfeCombobox.SelectedItem != null)
            {
                DataRowView drv = ProfeCombobox.SelectedItem as DataRowView;

                Debug.WriteLine("item " + drv.Row["nombre"].ToString());
                Debug.WriteLine("Value " + drv.Row["id_encargado"].ToString());
                Debug.WriteLine("Value " + ProfeCombobox.SelectedValue.ToString());
            }
         
        }

        private void capacidadTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DisponibilidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void dispoTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
