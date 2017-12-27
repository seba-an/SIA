using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utemAppWF
{
    public partial class agregarDatosForm : Form
    {
        public agregarDatosForm()
        {
           
            InitializeComponent();
            this.Text = "Agregar asignación";

            List<string> dias = new List<string>();
            dias.Add("Lunes");
            dias.Add("Martes");
            dias.Add("Miércoles");
            dias.Add("Jueves");
            dias.Add("Viernes");
            dias.Add("Sábado");

            diasCombobox.DataSource = dias;
            diasCombobox.SelectedIndex = -1;

           
            DataAccess dA = new DataAccess();
      

            dA.BindComboBox(ramoComboBox, $"select Nombre_Asignatura from Asignatura", "Nombre_Asignatura", "Asignatura", "id_asignatura");
            dA.BindComboBox(salaComboBox, $"select id_laboratorio, nombre from Laboratorio", "nombre", "Laboratorio", "id_laboratorio");
           

        }

        private void saveButton_Click(object sender, EventArgs e)
        {


            if(ramoComboBox != null || salaComboBox != null || diasCombobox != null || seccionComboBox != null)
            {
                DataSaving dS = new DataSaving();
                dS.agregarAsignacion(seccionComboBox, numSalaTxtBox, "id_seccion","id_laboratorio");

            }
            else
            {
                MessageBox.Show("No se han ingresado datos");
            }

        }

        private void ramoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess dA2 = new DataAccess();

            surnameTxtBox.Text = ""; 
            nameTxtBox.Text = "";

            if (ramoComboBox != null)
            {
                dA2.BindComboBox(seccionComboBox, $"select codigo from Seccion where seccion.asignatura == '" + ramoComboBox.Text + "'", 
                    "codigo", "Seccion", "id_seccion");
                dA2.nombreCompletoTextbox(ramoComboBox, nameTxtBox, $"select * from Encargado, Seccion where Seccion.asignatura == '" + ramoComboBox.Text + "' and Seccion.cod_encargado == Encargado.id_encargado", 
                    "nombre");
                dA2.nombreCompletoTextbox(ramoComboBox, surnameTxtBox, $"select * from Encargado, Seccion where Seccion.asignatura == '" + ramoComboBox.Text + "' and Seccion.cod_encargado == Encargado.id_encargado",
                    "apellido");

            }

        }

        private void seccionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void salaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess dA3 = new DataAccess();
            numSalaTxtBox.Text = "";

            if (salaComboBox != null)
            {
                dA3.fetchTextBox(salaComboBox, numSalaTxtBox, $"select * from laboratorio where laboratorio.nombre == '" + salaComboBox.Text + "'", "id_laboratorio");
            }
        }

        private void refreshBttn_Click(object sender, EventArgs e)
        {
            salaComboBox.Text = "";
            seccionComboBox.Text = "";
            ramoComboBox.Text = "";
            diasCombobox.Text = "";
            nameTxtBox.Text = "";
            surnameTxtBox.Text = "";
            numSalaTxtBox.Text = "";

        }




    }
}
