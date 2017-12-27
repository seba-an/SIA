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
            this.Text = "Sistema de Laboratorios UTEM";
            DataAccess da = new DataAccess();

            da.BindComboBox(asignaturaCombobox, $"select Nombre_Asignatura from Asignatura", "Nombre_Asignatura", "Asignatura", "id_asignatura");
            da.BindComboBox(LabCombobox, $"select id_laboratorio, nombre from Laboratorio", "nombre", "Laboratorio", "id_laboratorio");



        }


        private void LabCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Visible = false;
            DataAccess da = new DataAccess();
            if (asignaturaCombobox.Text != "" && LabCombobox.Text!="")
            {
 
            }
        }

        private void capacidadTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void asignaturaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            if (asignaturaCombobox!=null)
            {
                
                da.BindComboBox(comboBox1, "select codigo from Seccion where '" + asignaturaCombobox.Text + "' == Seccion.asignatura ", "codigo", "Seccion", "id_seccion");
                LabCombobox.Text = "";
                da.BindComboBox(LabCombobox, "select distinct nombre from Laboratorio,Asignacion,Seccion  where '" + asignaturaCombobox.Text + "'==Seccion.asignatura and Asignacion.cod_secc==Seccion.id_seccion and Laboratorio.id_laboratorio==Asignacion.cod_laboratorio",
               "nombre", "Laboratorio", "id_laboratorio");
            }

        }


        private void nombreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        agregarDatosForm addDataForm = null;

        private void addAsignButton_Click(object sender, EventArgs e)
        {
            if (addDataForm == null)
            {
                addDataForm = new agregarDatosForm();
                addDataForm.FormClosed += new FormClosedEventHandler(addDataForm_FormClosed);
                addDataForm.Show(this);

            }
            else
            {
                addDataForm.BringToFront();
            }    
        }

        private void addDataForm_FormClosed(object sender, EventArgs e)
        {
            addDataForm = null;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            comboBox1.Text = "";
            nombreTxtBox.Text = "";
            apellidoTxtBox.Text = "";
            LabCombobox.Text = "";
            asignaturaCombobox.Text = "";
            capacidadTextbox.Text = "";
            dispoTextBox.Text = "";
            da.BindComboBox(asignaturaCombobox, $"select Nombre_Asignatura from Asignatura", "Nombre_Asignatura", "Asignatura", "id_asignatura");
            da.BindComboBox(LabCombobox, $"select id_laboratorio, nombre from Laboratorio", "nombre", "Laboratorio", "id_laboratorio");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();

            da.nombreCompletoTextbox(asignaturaCombobox, nombreTxtBox,
                 $"select * " +
                 $"from  Encargado , Seccion " +
                 $"where Seccion.asignatura =='" + asignaturaCombobox.Text + "' and  '" + comboBox1.Text + 
                 $"'==Seccion.Codigo  and Seccion.cod_encargado==Encargado.id_encargado"  ,
                  "nombre");
            da.nombreCompletoTextbox(asignaturaCombobox, apellidoTxtBox,
                 $"select * " +
                 $"from Encargado , Seccion " +
                 $"where Seccion.asignatura =='"+ asignaturaCombobox.Text + "' and  '" + comboBox1.Text +
                 $"'==Seccion.Codigo  and Seccion.cod_encargado==Encargado.id_encargado",
                  "apellido");

            if (LabCombobox.Text != "")
            {

                da.nombreCompletoTextbox(asignaturaCombobox, capacidadTextbox,
                    $"select * " +
                    $"from  Laboratorio " +
                    $"where Laboratorio.nombre=='"+LabCombobox.Text+"'",
                    "capacidad");
            }
   


            if (LabCombobox.Text != "" && asignaturaCombobox.Text=="")
            {
                da.GetData("select distinct Periodo,Lunes,Martes,Miercoles,Jueves,Viernes,Sabado from Vista,Laboratorio where (Laboratorio.nombre=='"+LabCombobox.Text+"' and Laboratorio.id_laboratorio==cod_secc) or Vista.seccion==0", dataGridView1);
            }
            if (LabCombobox.Text != "" && asignaturaCombobox.Text != "")
            {
                da.GetData("select distinct Periodo,Lunes,Martes,Miercoles,Jueves,Viernes,Sabado from Vista,Laboratorio,Seccion where ((Laboratorio.nombre=='" + LabCombobox.Text + "' and Laboratorio.id_laboratorio==cod_secc) and (Seccion.id_seccion==Vista.cod_asig)  and ('"+asignaturaCombobox.Text+"' == Seccion.asignatura )) or Vista.Seccion==0", dataGridView1);
            }


            if (asignaturaCombobox.Text != "" && comboBox1.Text != "")
            {
                da.nombreCompletoTextbox(asignaturaCombobox, dispoTextBox,
                  $"select * " +
                  $"from  Seccion " +
                  $"where Seccion.asignatura=='"+asignaturaCombobox.Text+"' and Seccion.codigo=='"+comboBox1.Text+"' ",
                  "cantidad");   
            }
            if (asignaturaCombobox.Text == "" && comboBox1.Text == "" && LabCombobox.Text == "")
            {

                label3.Visible = true;
              
            }


        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
   
        }

        private void LabCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void LabCombobox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void LabCombobox_Click(object sender, EventArgs e)
        {

            
        }

        private void DisponibilidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

   
    }
}
