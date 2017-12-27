namespace utemAppWF
{
    partial class agregarDatosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ramoComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.surnameTxtBox = new System.Windows.Forms.TextBox();
            this.salaComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.diasCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.seccionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSalaTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.refreshBttn = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ramoComboBox
            // 
            this.ramoComboBox.FormattingEnabled = true;
            this.ramoComboBox.Location = new System.Drawing.Point(161, 51);
            this.ramoComboBox.Name = "ramoComboBox";
            this.ramoComboBox.Size = new System.Drawing.Size(307, 21);
            this.ramoComboBox.TabIndex = 0;
            this.ramoComboBox.SelectedIndexChanged += new System.EventHandler(this.ramoComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escoger Asignatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesor que Imparte";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(161, 88);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(147, 20);
            this.nameTxtBox.TabIndex = 3;
       
            // 
            // surnameTxtBox
            // 
            this.surnameTxtBox.Location = new System.Drawing.Point(321, 88);
            this.surnameTxtBox.Name = "surnameTxtBox";
            this.surnameTxtBox.Size = new System.Drawing.Size(147, 20);
            this.surnameTxtBox.TabIndex = 4;
      
            // 
            // salaComboBox
            // 
            this.salaComboBox.FormattingEnabled = true;
            this.salaComboBox.Location = new System.Drawing.Point(161, 123);
            this.salaComboBox.Name = "salaComboBox";
            this.salaComboBox.Size = new System.Drawing.Size(307, 21);
            this.salaComboBox.TabIndex = 5;
            this.salaComboBox.SelectedIndexChanged += new System.EventHandler(this.salaComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escoger Sala";
            // 
            // diasCombobox
            // 
            this.diasCombobox.FormattingEnabled = true;
            this.diasCombobox.Location = new System.Drawing.Point(161, 160);
            this.diasCombobox.Name = "diasCombobox";
            this.diasCombobox.Size = new System.Drawing.Size(307, 21);
            this.diasCombobox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Escoger Día";
            // 
            // seccionComboBox
            // 
            this.seccionComboBox.FormattingEnabled = true;
            this.seccionComboBox.Location = new System.Drawing.Point(531, 51);
            this.seccionComboBox.Name = "seccionComboBox";
            this.seccionComboBox.Size = new System.Drawing.Size(92, 21);
            this.seccionComboBox.TabIndex = 10;
            this.seccionComboBox.SelectedIndexChanged += new System.EventHandler(this.seccionComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sección";
            // 
            // numSalaTxtBox
            // 
            this.numSalaTxtBox.Location = new System.Drawing.Point(531, 123);
            this.numSalaTxtBox.Name = "numSalaTxtBox";
            this.numSalaTxtBox.Size = new System.Drawing.Size(92, 20);
            this.numSalaTxtBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "N° Sala";
            // 
            // refreshBttn
            // 
            this.refreshBttn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBttn.Image = global::utemAppWF.Properties.Resources.if_sync_126579__1_1;
            this.refreshBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refreshBttn.Location = new System.Drawing.Point(507, 211);
            this.refreshBttn.Name = "refreshBttn";
            this.refreshBttn.Size = new System.Drawing.Size(116, 44);
            this.refreshBttn.TabIndex = 14;
            this.refreshBttn.Text = "Refrescar";
            this.refreshBttn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refreshBttn.UseVisualStyleBackColor = true;
            this.refreshBttn.Click += new System.EventHandler(this.refreshBttn_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Image = global::utemAppWF.Properties.Resources.sign_check_icon__1_;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.Location = new System.Drawing.Point(28, 211);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(114, 44);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Guardar";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // agregarDatosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 344);
            this.Controls.Add(this.refreshBttn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numSalaTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seccionComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diasCombobox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salaComboBox);
            this.Controls.Add(this.surnameTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ramoComboBox);
            this.Name = "agregarDatosForm";
            this.Text = "agregarDatosForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ramoComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox surnameTxtBox;
        private System.Windows.Forms.ComboBox salaComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox diasCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox seccionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numSalaTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button refreshBttn;
    }
}