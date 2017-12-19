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
      

            dA.BindComboBox(ramoComboBox, $"select id_seccion, asignatura from Seccion", "asignatura", "id_seccion", "Seccion");
            dA.BindComboBox(salaComboBox, $"select id_laboratorio, nombre from Laboratorio", "nombre", "Laboratorio", "id_laboratorio"); 

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DataSaving dS = new DataSaving();

            dS.agregarAsignacion(ramoComboBox,salaComboBox,diasCombobox,"id_encargado","id_seccion");
        }
    }
}
