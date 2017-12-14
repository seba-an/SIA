﻿using System;
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
            capacidadTextbox.Text = " ";
            dispoTextBox.Text = " ";
            if (LabCombobox.SelectedItem != null)
            {
                DataRowView drv = LabCombobox.SelectedItem as DataRowView;

                Debug.WriteLine("item " + drv.Row["nombre"].ToString());
                Debug.WriteLine("Value " + drv.Row["id_laboratorio"].ToString());
                Debug.WriteLine("Value " + LabCombobox.SelectedValue.ToString());
           
                DataAccess da2 = new DataAccess();

                da2.fetchTextBox(LabCombobox, capacidadTextbox, $"select * from Laboratorio where nombre = '" + LabCombobox.Text + "'", "capacidad", "Laboratorio", "id_laboratorio");

                da2.disponibilidadTextBox(LabCombobox, dispoTextBox, $"select * from Laboratorio where nombre = '" + LabCombobox.Text + "'", "disponibilidad", "Laboratorio", "id_laboratorio");
            }

        }



        private void capacidadTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void asignaturaCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            nombreTxtBox.Text = " ";
            apellidoTxtBox.Text = " ";
            if (asignaturaCombobox.SelectedItem != null)
            {
                DataRowView drv = asignaturaCombobox.SelectedItem as DataRowView;

                Debug.WriteLine("item " + drv.Row["asignatura"].ToString());
                Debug.WriteLine("Value " + drv.Row["id_seccion"].ToString());
                Debug.WriteLine("Value " + asignaturaCombobox.SelectedValue.ToString());

                DataAccess da3 = new DataAccess();

                da3.nombreCompletoTextbox(asignaturaCombobox, nombreTxtBox, 
                    $"select r.id_representante, en.id_encargado, en.nombre, se.id_seccion, se.asignatura " +
                    $"from Representante as r, Encargado as en, Seccion as se  " +
                    $"where en.id_encargado = r.cod_encargado and se.id_seccion = r.cod_seccion and se.asignatura ='" + asignaturaCombobox.Text +"'" ,
                    "nombre", "Encargado", "id_representante" , "id_encargado");

                da3.nombreCompletoTextbox(asignaturaCombobox, apellidoTxtBox,
                 $"select r.id_representante, en.id_encargado, en.apellido, se.id_seccion, se.asignatura " +
                 $"from Representante as r, Encargado as en, Seccion as se  " +
                 $"where en.id_encargado = r.cod_encargado and se.id_seccion = r.cod_seccion and se.asignatura ='" + asignaturaCombobox.Text + "'",
                 "apellido", "Encargado", "id_representante", "id_encargado"); 

            
            }
        }

        private void nombreTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellidoTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}