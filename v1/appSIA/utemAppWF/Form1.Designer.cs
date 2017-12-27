namespace utemAppWF
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabCombobox = new System.Windows.Forms.ComboBox();
            this.ProfeLabel = new System.Windows.Forms.Label();
            this.LaboratorioLabel = new System.Windows.Forms.Label();
            this.capacidadTextbox = new System.Windows.Forms.TextBox();
            this.capacidadLabel = new System.Windows.Forms.Label();
            this.dispoTextBox = new System.Windows.Forms.TextBox();
            this.primerPerLabel = new System.Windows.Forms.Label();
            this.segunPerLabel = new System.Windows.Forms.Label();
            this.tercerPerLabel = new System.Windows.Forms.Label();
            this.cuartoPerLabel = new System.Windows.Forms.Label();
            this.quintoPerLabel = new System.Windows.Forms.Label();
            this.sextoPerLabel = new System.Windows.Forms.Label();
            this.septPerLabel = new System.Windows.Forms.Label();
            this.octPerLabel = new System.Windows.Forms.Label();
            this.novPerLabel = new System.Windows.Forms.Label();
            this.asignaturaCombobox = new System.Windows.Forms.ComboBox();
            this.asignaturaLabel = new System.Windows.Forms.Label();
            this.nombreTxtBox = new System.Windows.Forms.TextBox();
            this.apellidoTxtBox = new System.Windows.Forms.TextBox();
            this.addAsignButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabCombobox
            // 
            this.LabCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LabCombobox.FormattingEnabled = true;
            this.LabCombobox.Location = new System.Drawing.Point(114, 62);
            this.LabCombobox.Name = "LabCombobox";
            this.LabCombobox.Size = new System.Drawing.Size(502, 21);
            this.LabCombobox.TabIndex = 2;
            this.LabCombobox.SelectedIndexChanged += new System.EventHandler(this.LabCombobox_SelectedIndexChanged);
            this.LabCombobox.SelectionChangeCommitted += new System.EventHandler(this.LabCombobox_SelectionChangeCommitted);
            this.LabCombobox.Click += new System.EventHandler(this.LabCombobox_Click);
            this.LabCombobox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LabCombobox_MouseClick);
            // 
            // ProfeLabel
            // 
            this.ProfeLabel.AutoSize = true;
            this.ProfeLabel.Location = new System.Drawing.Point(26, 100);
            this.ProfeLabel.Name = "ProfeLabel";
            this.ProfeLabel.Size = new System.Drawing.Size(54, 13);
            this.ProfeLabel.TabIndex = 2;
            this.ProfeLabel.Text = "Docente";
            // 
            // LaboratorioLabel
            // 
            this.LaboratorioLabel.AutoSize = true;
            this.LaboratorioLabel.Location = new System.Drawing.Point(26, 65);
            this.LaboratorioLabel.Name = "LaboratorioLabel";
            this.LaboratorioLabel.Size = new System.Drawing.Size(72, 13);
            this.LaboratorioLabel.TabIndex = 3;
            this.LaboratorioLabel.Text = "Laboratorio";
            // 
            // capacidadTextbox
            // 
            this.capacidadTextbox.Location = new System.Drawing.Point(114, 132);
            this.capacidadTextbox.Name = "capacidadTextbox";
            this.capacidadTextbox.Size = new System.Drawing.Size(100, 21);
            this.capacidadTextbox.TabIndex = 4;
            this.capacidadTextbox.TextChanged += new System.EventHandler(this.capacidadTextbox_TextChanged);
            // 
            // capacidadLabel
            // 
            this.capacidadLabel.AutoSize = true;
            this.capacidadLabel.Location = new System.Drawing.Point(27, 135);
            this.capacidadLabel.Name = "capacidadLabel";
            this.capacidadLabel.Size = new System.Drawing.Size(67, 13);
            this.capacidadLabel.TabIndex = 5;
            this.capacidadLabel.Text = "Capacidad";
            // 
            // dispoTextBox
            // 
            this.dispoTextBox.Location = new System.Drawing.Point(312, 132);
            this.dispoTextBox.Name = "dispoTextBox";
            this.dispoTextBox.Size = new System.Drawing.Size(102, 21);
            this.dispoTextBox.TabIndex = 7;
            // 
            // primerPerLabel
            // 
            this.primerPerLabel.AutoSize = true;
            this.primerPerLabel.Location = new System.Drawing.Point(44, 230);
            this.primerPerLabel.Name = "primerPerLabel";
            this.primerPerLabel.Size = new System.Drawing.Size(64, 13);
            this.primerPerLabel.TabIndex = 63;
            this.primerPerLabel.Text = "8:00-9:30";
            // 
            // segunPerLabel
            // 
            this.segunPerLabel.AutoSize = true;
            this.segunPerLabel.Location = new System.Drawing.Point(37, 261);
            this.segunPerLabel.Name = "segunPerLabel";
            this.segunPerLabel.Size = new System.Drawing.Size(71, 13);
            this.segunPerLabel.TabIndex = 64;
            this.segunPerLabel.Text = "9:40-11:10";
            // 
            // tercerPerLabel
            // 
            this.tercerPerLabel.AutoSize = true;
            this.tercerPerLabel.Location = new System.Drawing.Point(30, 292);
            this.tercerPerLabel.Name = "tercerPerLabel";
            this.tercerPerLabel.Size = new System.Drawing.Size(78, 13);
            this.tercerPerLabel.TabIndex = 65;
            this.tercerPerLabel.Text = "11:20-12:50";
            // 
            // cuartoPerLabel
            // 
            this.cuartoPerLabel.AutoSize = true;
            this.cuartoPerLabel.Location = new System.Drawing.Point(30, 323);
            this.cuartoPerLabel.Name = "cuartoPerLabel";
            this.cuartoPerLabel.Size = new System.Drawing.Size(78, 13);
            this.cuartoPerLabel.TabIndex = 66;
            this.cuartoPerLabel.Text = "13:00-14:30";
            // 
            // quintoPerLabel
            // 
            this.quintoPerLabel.AutoSize = true;
            this.quintoPerLabel.Location = new System.Drawing.Point(30, 354);
            this.quintoPerLabel.Name = "quintoPerLabel";
            this.quintoPerLabel.Size = new System.Drawing.Size(78, 13);
            this.quintoPerLabel.TabIndex = 67;
            this.quintoPerLabel.Text = "14:40-16:10";
            // 
            // sextoPerLabel
            // 
            this.sextoPerLabel.AutoSize = true;
            this.sextoPerLabel.Location = new System.Drawing.Point(30, 385);
            this.sextoPerLabel.Name = "sextoPerLabel";
            this.sextoPerLabel.Size = new System.Drawing.Size(78, 13);
            this.sextoPerLabel.TabIndex = 68;
            this.sextoPerLabel.Text = "16:20-17:50";
            // 
            // septPerLabel
            // 
            this.septPerLabel.AutoSize = true;
            this.septPerLabel.Location = new System.Drawing.Point(30, 416);
            this.septPerLabel.Name = "septPerLabel";
            this.septPerLabel.Size = new System.Drawing.Size(78, 13);
            this.septPerLabel.TabIndex = 69;
            this.septPerLabel.Text = "18:00-19:30";
            // 
            // octPerLabel
            // 
            this.octPerLabel.AutoSize = true;
            this.octPerLabel.Location = new System.Drawing.Point(30, 447);
            this.octPerLabel.Name = "octPerLabel";
            this.octPerLabel.Size = new System.Drawing.Size(78, 13);
            this.octPerLabel.TabIndex = 70;
            this.octPerLabel.Text = "19:40-21:10";
            // 
            // novPerLabel
            // 
            this.novPerLabel.AutoSize = true;
            this.novPerLabel.Location = new System.Drawing.Point(30, 478);
            this.novPerLabel.Name = "novPerLabel";
            this.novPerLabel.Size = new System.Drawing.Size(78, 13);
            this.novPerLabel.TabIndex = 71;
            this.novPerLabel.Text = "21:20-22:50";
            // 
            // asignaturaCombobox
            // 
            this.asignaturaCombobox.FormattingEnabled = true;
            this.asignaturaCombobox.Location = new System.Drawing.Point(114, 26);
            this.asignaturaCombobox.Name = "asignaturaCombobox";
            this.asignaturaCombobox.Size = new System.Drawing.Size(502, 21);
            this.asignaturaCombobox.TabIndex = 1;
            this.asignaturaCombobox.SelectedIndexChanged += new System.EventHandler(this.asignaturaCombobox_SelectedIndexChanged);
            // 
            // asignaturaLabel
            // 
            this.asignaturaLabel.AutoSize = true;
            this.asignaturaLabel.Location = new System.Drawing.Point(26, 29);
            this.asignaturaLabel.Name = "asignaturaLabel";
            this.asignaturaLabel.Size = new System.Drawing.Size(68, 13);
            this.asignaturaLabel.TabIndex = 82;
            this.asignaturaLabel.Text = "Asignatura";
            // 
            // nombreTxtBox
            // 
            this.nombreTxtBox.Location = new System.Drawing.Point(114, 97);
            this.nombreTxtBox.Name = "nombreTxtBox";
            this.nombreTxtBox.Size = new System.Drawing.Size(147, 21);
            this.nombreTxtBox.TabIndex = 83;
            this.nombreTxtBox.TextChanged += new System.EventHandler(this.nombreTxtBox_TextChanged);
            // 
            // apellidoTxtBox
            // 
            this.apellidoTxtBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.apellidoTxtBox.Location = new System.Drawing.Point(267, 97);
            this.apellidoTxtBox.Name = "apellidoTxtBox";
            this.apellidoTxtBox.Size = new System.Drawing.Size(147, 21);
            this.apellidoTxtBox.TabIndex = 84;
            this.apellidoTxtBox.TextChanged += new System.EventHandler(this.apellidoTxtBox_TextChanged);
            // 
            // addAsignButton
            // 
            this.addAsignButton.Image = global::utemAppWF.Properties.Resources.add_1_icon;
            this.addAsignButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAsignButton.Location = new System.Drawing.Point(682, 26);
            this.addAsignButton.Name = "addAsignButton";
            this.addAsignButton.Size = new System.Drawing.Size(156, 36);
            this.addAsignButton.TabIndex = 6;
            this.addAsignButton.Text = "Agregar asignación...";
            this.addAsignButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addAsignButton.UseVisualStyleBackColor = true;
            this.addAsignButton.Click += new System.EventHandler(this.addAsignButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(682, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(114, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(724, 249);
            this.dataGridView1.TabIndex = 88;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Tamaño Curso";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Secc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(111, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 13);
            this.label3.TabIndex = 91;
            this.label3.Text = "Seleccione almenos un laboratorio o una asignatura con seccion";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAsignButton);
            this.Controls.Add(this.apellidoTxtBox);
            this.Controls.Add(this.nombreTxtBox);
            this.Controls.Add(this.asignaturaLabel);
            this.Controls.Add(this.asignaturaCombobox);
            this.Controls.Add(this.novPerLabel);
            this.Controls.Add(this.octPerLabel);
            this.Controls.Add(this.septPerLabel);
            this.Controls.Add(this.sextoPerLabel);
            this.Controls.Add(this.quintoPerLabel);
            this.Controls.Add(this.cuartoPerLabel);
            this.Controls.Add(this.tercerPerLabel);
            this.Controls.Add(this.segunPerLabel);
            this.Controls.Add(this.primerPerLabel);
            this.Controls.Add(this.dispoTextBox);
            this.Controls.Add(this.capacidadLabel);
            this.Controls.Add(this.capacidadTextbox);
            this.Controls.Add(this.LaboratorioLabel);
            this.Controls.Add(this.ProfeLabel);
            this.Controls.Add(this.LabCombobox);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox LabCombobox;
        private System.Windows.Forms.Label ProfeLabel;
        private System.Windows.Forms.Label LaboratorioLabel;
        private System.Windows.Forms.TextBox capacidadTextbox;
        private System.Windows.Forms.Label capacidadLabel;
        private System.Windows.Forms.TextBox dispoTextBox;
        private System.Windows.Forms.Label primerPerLabel;
        private System.Windows.Forms.Label segunPerLabel;
        private System.Windows.Forms.Label tercerPerLabel;
        private System.Windows.Forms.Label cuartoPerLabel;
        private System.Windows.Forms.Label quintoPerLabel;
        private System.Windows.Forms.Label sextoPerLabel;
        private System.Windows.Forms.Label septPerLabel;
        private System.Windows.Forms.Label octPerLabel;
        private System.Windows.Forms.Label novPerLabel;
        private System.Windows.Forms.ComboBox asignaturaCombobox;
        private System.Windows.Forms.Label asignaturaLabel;
        private System.Windows.Forms.TextBox nombreTxtBox;
        private System.Windows.Forms.TextBox apellidoTxtBox;
        private System.Windows.Forms.Button addAsignButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

