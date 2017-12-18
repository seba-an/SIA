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

            da.BindComboBox(asignaturaCombobox, $"select id_seccion, asignatura from Seccion", "asignatura", "id_seccion", "Seccion");
            da.BindComboBox(LabCombobox, $"select id_laboratorio, nombre from Laboratorio", "nombre", "Laboratorio", "id_laboratorio");  
            

        }

        private void LabCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cleanTxt();

            if (LabCombobox.SelectedItem != null)
            {
                DataRowView drv = LabCombobox.SelectedItem as DataRowView;
                
                Debug.WriteLine("item " + drv.Row["nombre"].ToString());
                Debug.WriteLine("Value " + drv.Row["id_laboratorio"].ToString());
                Debug.WriteLine("Value " + LabCombobox.SelectedValue.ToString());
                
                DataAccess da2 = new DataAccess();

                da2.fetchTextBox(LabCombobox, capacidadTextbox, $"select * from Laboratorio where nombre = '" + LabCombobox.Text + "'", "capacidad");

                da2.disponibilidadTextBox(LabCombobox, dispoTextBox, $"select * from Laboratorio where nombre = '" + LabCombobox.Text + "'", "disponibilidad");
                
              

            }


        }



        private void capacidadTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void asignaturaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cleanTxt();


            /*
            if (asignaturaCombobox.SelectedItem != null)
            {
                DataRowView drv = asignaturaCombobox.SelectedItem as DataRowView;

                Debug.WriteLine("item " + drv.Row["asignatura"].ToString());
                Debug.WriteLine("Value " + drv.Row["id_seccion"].ToString());
                Debug.WriteLine("Value " + asignaturaCombobox.SelectedValue.ToString());


         

            
            }*/
        }

        private void cleanCombo()
        {
            LabCombobox.Text = null;
            asignaturaCombobox.Text = null;
        }
        private void cleanTxt()
        {
            nombreTxtBox.Text = " ";
            apellidoTxtBox.Text = " ";
            capacidadTextbox.Text = " ";
            dispoTextBox.Text = " ";

            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            textBox6.Text = " ";
            textBox7.Text = " ";
            textBox8.Text = " ";
            textBox9.Text = " ";
            textBox10.Text = " ";
            textBox11.Text = " ";
            textBox12.Text = " ";
            textBox13.Text = " ";
            textBox14.Text = " ";
            textBox15.Text = " ";
            textBox16.Text = " ";
            textBox17.Text = " ";
            textBox18.Text = " ";
            textBox19.Text = " ";
            textBox20.Text = " ";
            textBox21.Text = " ";
            textBox22.Text = " ";
            textBox23.Text = " ";
            textBox24.Text = " ";
            textBox25.Text = " ";
            textBox26.Text = " ";
            textBox27.Text = " ";
            textBox28.Text = " ";
            textBox29.Text = " ";
            textBox30.Text = " ";
            textBox31.Text = " ";
            textBox32.Text = " ";
            textBox33.Text = " ";
            textBox34.Text = " ";
            textBox35.Text = " ";
            textBox36.Text = " ";
            textBox37.Text = " ";
            textBox38.Text = " ";
            textBox39.Text = " ";
            textBox40.Text = " ";
            textBox41.Text = " ";
            textBox42.Text = " ";
            textBox43.Text = " ";
            textBox44.Text = " ";
            textBox45.Text = " ";
            textBox46.Text = " ";
            textBox47.Text = " ";
            textBox48.Text = " ";
            textBox49.Text = " ";
            textBox50.Text = " ";
            textBox51.Text = " ";
            textBox52.Text = " ";
            textBox53.Text = " ";
            textBox54.Text = " ";
            

        }

        private void nombreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addAsignButton_Click(object sender, EventArgs e)
        {
            agregarDatosForm addDataForm = new agregarDatosForm();
            addDataForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleanCombo();
            cleanTxt();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess da3 = new DataAccess();
            if (asignaturaCombobox !=null && LabCombobox != null)
            {
                da3.nombreCompletoTextbox(asignaturaCombobox, nombreTxtBox,
                    $"select r.id_representante, en.id_encargado, en.nombre, se.id_seccion, se.asignatura " +
                    $"from Representante as r, Encargado as en, Seccion as se  " +
                    $"where en.id_encargado = r.cod_encargado and se.id_seccion = r.cod_seccion and se.asignatura ='" + asignaturaCombobox.Text + "'",
                    "nombre");

                da3.nombreCompletoTextbox(asignaturaCombobox, apellidoTxtBox,
                    $"select r.id_representante, en.id_encargado, en.apellido, se.id_seccion, se.asignatura " +
                    $"from Representante as r, Encargado as en, Seccion as se  " +
                    $"where en.id_encargado = r.cod_encargado and se.id_seccion = r.cod_seccion and se.asignatura ='" + asignaturaCombobox.Text + "'",
                    "apellido");

                da3.nombreCompletoTextbox(asignaturaCombobox, textBox1,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=1 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox7,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=2 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox13,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=3 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox19,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=4 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox25,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=5 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox31,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=6 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox37,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=7 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox43,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=8 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox49,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where se.asignatura='" + asignaturaCombobox.Text + "' and Periodo.NPeriodo=9 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio and  se.codigo=Periodo.secc",
                    "codigo");

            }
            if (asignaturaCombobox == null && LabCombobox != null)
            {

                da3.nombreCompletoTextbox(asignaturaCombobox, textBox1,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where  Periodo.NPeriodo=1 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio",
                    "Nombre_Laboratorio");
                da3.nombreCompletoTextbox(asignaturaCombobox, textBox7,
                    $"select Laboratorio.Nombre, Periodo.Nombre_Laboratorio, Periodo.NPeriodo,Periodo.Nombre_Dia,r.id_representante, se.codigo, se.asignatura " +
                    $"from  laboratorio, Representante as r, Periodo, Seccion as se  " +
                    $"where  Periodo.NPeriodo=2 and Periodo.Nombre_Dia='Lunes' and" +
                    $"'" + LabCombobox.Text + "'=Periodo.Nombre_Laboratorio",
                    "Nombre_Laboratorio");
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
