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
            this.ProfeCombobox = new System.Windows.Forms.ComboBox();
            this.LabCombobox = new System.Windows.Forms.ComboBox();
            this.ProfeLabel = new System.Windows.Forms.Label();
            this.LaboratorioLabel = new System.Windows.Forms.Label();
            this.capacidadTextbox = new System.Windows.Forms.TextBox();
            this.capacidadLabel = new System.Windows.Forms.Label();
            this.DisponibilidadLabel = new System.Windows.Forms.Label();
            this.dispoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProfeCombobox
            // 
            this.ProfeCombobox.FormattingEnabled = true;
            this.ProfeCombobox.Location = new System.Drawing.Point(114, 59);
            this.ProfeCombobox.Name = "ProfeCombobox";
            this.ProfeCombobox.Size = new System.Drawing.Size(502, 21);
            this.ProfeCombobox.TabIndex = 0;
            this.ProfeCombobox.SelectedIndexChanged += new System.EventHandler(this.ProfeCombobox_SelectedIndexChanged);
            // 
            // LabCombobox
            // 
            this.LabCombobox.FormattingEnabled = true;
            this.LabCombobox.Location = new System.Drawing.Point(114, 178);
            this.LabCombobox.Name = "LabCombobox";
            this.LabCombobox.Size = new System.Drawing.Size(502, 21);
            this.LabCombobox.TabIndex = 1;
            this.LabCombobox.SelectedIndexChanged += new System.EventHandler(this.LabCombobox_SelectedIndexChanged);
            // 
            // ProfeLabel
            // 
            this.ProfeLabel.AutoSize = true;
            this.ProfeLabel.Location = new System.Drawing.Point(26, 62);
            this.ProfeLabel.Name = "ProfeLabel";
            this.ProfeLabel.Size = new System.Drawing.Size(54, 13);
            this.ProfeLabel.TabIndex = 2;
            this.ProfeLabel.Text = "Docente";
            // 
            // LaboratorioLabel
            // 
            this.LaboratorioLabel.AutoSize = true;
            this.LaboratorioLabel.Location = new System.Drawing.Point(26, 181);
            this.LaboratorioLabel.Name = "LaboratorioLabel";
            this.LaboratorioLabel.Size = new System.Drawing.Size(72, 13);
            this.LaboratorioLabel.TabIndex = 3;
            this.LaboratorioLabel.Text = "Laboratorio";
            this.LaboratorioLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // capacidadTextbox
            // 
            this.capacidadTextbox.Location = new System.Drawing.Point(114, 221);
            this.capacidadTextbox.Name = "capacidadTextbox";
            this.capacidadTextbox.Size = new System.Drawing.Size(100, 21);
            this.capacidadTextbox.TabIndex = 4;
            this.capacidadTextbox.TextChanged += new System.EventHandler(this.capacidadTextbox_TextChanged);
            // 
            // capacidadLabel
            // 
            this.capacidadLabel.AutoSize = true;
            this.capacidadLabel.Location = new System.Drawing.Point(26, 224);
            this.capacidadLabel.Name = "capacidadLabel";
            this.capacidadLabel.Size = new System.Drawing.Size(67, 13);
            this.capacidadLabel.TabIndex = 5;
            this.capacidadLabel.Text = "Capacidad";
            this.capacidadLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DisponibilidadLabel
            // 
            this.DisponibilidadLabel.AutoSize = true;
            this.DisponibilidadLabel.Location = new System.Drawing.Point(220, 224);
            this.DisponibilidadLabel.Name = "DisponibilidadLabel";
            this.DisponibilidadLabel.Size = new System.Drawing.Size(86, 13);
            this.DisponibilidadLabel.TabIndex = 6;
            this.DisponibilidadLabel.Text = "Disponibilidad";
            this.DisponibilidadLabel.Click += new System.EventHandler(this.DisponibilidadLabel_Click);
            // 
            // dispoTextBox
            // 
            this.dispoTextBox.Location = new System.Drawing.Point(312, 221);
            this.dispoTextBox.Name = "dispoTextBox";
            this.dispoTextBox.Size = new System.Drawing.Size(100, 21);
            this.dispoTextBox.TabIndex = 7;
            this.dispoTextBox.TextChanged += new System.EventHandler(this.dispoTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 487);
            this.Controls.Add(this.dispoTextBox);
            this.Controls.Add(this.DisponibilidadLabel);
            this.Controls.Add(this.capacidadLabel);
            this.Controls.Add(this.capacidadTextbox);
            this.Controls.Add(this.LaboratorioLabel);
            this.Controls.Add(this.ProfeLabel);
            this.Controls.Add(this.LabCombobox);
            this.Controls.Add(this.ProfeCombobox);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProfeCombobox;
        private System.Windows.Forms.ComboBox LabCombobox;
        private System.Windows.Forms.Label ProfeLabel;
        private System.Windows.Forms.Label LaboratorioLabel;
        private System.Windows.Forms.TextBox capacidadTextbox;
        private System.Windows.Forms.Label capacidadLabel;
        private System.Windows.Forms.Label DisponibilidadLabel;
        private System.Windows.Forms.TextBox dispoTextBox;
    }
}

