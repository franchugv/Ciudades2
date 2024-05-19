namespace Ciudades2
{
    partial class FormCiudades
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
            this.buttonAgregarProvincia = new System.Windows.Forms.Button();
            this.labelAgregarProvincia = new System.Windows.Forms.Label();
            this.comboBoxListaProvincias = new System.Windows.Forms.ComboBox();
            this.textBoxAgregarProvincia = new System.Windows.Forms.TextBox();
            this.labelListaProvincias = new System.Windows.Forms.Label();
            this.labelListsaCiudades = new System.Windows.Forms.Label();
            this.textBoxAgregarCiudad = new System.Windows.Forms.TextBox();
            this.comboBoxListaCiudades = new System.Windows.Forms.ComboBox();
            this.labelAgregarCiudad = new System.Windows.Forms.Label();
            this.buttonAgregarCiudad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAgregarProvincia
            // 
            this.buttonAgregarProvincia.Location = new System.Drawing.Point(30, 124);
            this.buttonAgregarProvincia.Name = "buttonAgregarProvincia";
            this.buttonAgregarProvincia.Size = new System.Drawing.Size(277, 23);
            this.buttonAgregarProvincia.TabIndex = 0;
            this.buttonAgregarProvincia.Text = "Agregar Provincia";
            this.buttonAgregarProvincia.UseVisualStyleBackColor = true;
            this.buttonAgregarProvincia.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // labelAgregarProvincia
            // 
            this.labelAgregarProvincia.AutoSize = true;
            this.labelAgregarProvincia.Location = new System.Drawing.Point(27, 43);
            this.labelAgregarProvincia.Name = "labelAgregarProvincia";
            this.labelAgregarProvincia.Size = new System.Drawing.Size(94, 13);
            this.labelAgregarProvincia.TabIndex = 2;
            this.labelAgregarProvincia.Text = "Agregar Provincia:";
            // 
            // comboBoxListaProvincias
            // 
            this.comboBoxListaProvincias.FormattingEnabled = true;
            this.comboBoxListaProvincias.Location = new System.Drawing.Point(124, 84);
            this.comboBoxListaProvincias.Name = "comboBoxListaProvincias";
            this.comboBoxListaProvincias.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaProvincias.TabIndex = 3;
            this.comboBoxListaProvincias.SelectedIndexChanged += new System.EventHandler(this.comboBoxListaProvincias_SelectedIndexChanged);
            // 
            // textBoxAgregarProvincia
            // 
            this.textBoxAgregarProvincia.Location = new System.Drawing.Point(124, 40);
            this.textBoxAgregarProvincia.Name = "textBoxAgregarProvincia";
            this.textBoxAgregarProvincia.Size = new System.Drawing.Size(183, 20);
            this.textBoxAgregarProvincia.TabIndex = 4;
            // 
            // labelListaProvincias
            // 
            this.labelListaProvincias.AutoSize = true;
            this.labelListaProvincias.Location = new System.Drawing.Point(59, 87);
            this.labelListaProvincias.Name = "labelListaProvincias";
            this.labelListaProvincias.Size = new System.Drawing.Size(59, 13);
            this.labelListaProvincias.TabIndex = 5;
            this.labelListaProvincias.Text = "Provincias:";
            // 
            // labelListsaCiudades
            // 
            this.labelListsaCiudades.AutoSize = true;
            this.labelListsaCiudades.Location = new System.Drawing.Point(59, 224);
            this.labelListsaCiudades.Name = "labelListsaCiudades";
            this.labelListsaCiudades.Size = new System.Drawing.Size(54, 13);
            this.labelListsaCiudades.TabIndex = 10;
            this.labelListsaCiudades.Text = "Ciudades:";
            // 
            // textBoxAgregarCiudad
            // 
            this.textBoxAgregarCiudad.Enabled = false;
            this.textBoxAgregarCiudad.Location = new System.Drawing.Point(124, 177);
            this.textBoxAgregarCiudad.Name = "textBoxAgregarCiudad";
            this.textBoxAgregarCiudad.Size = new System.Drawing.Size(183, 20);
            this.textBoxAgregarCiudad.TabIndex = 9;
            // 
            // comboBoxListaCiudades
            // 
            this.comboBoxListaCiudades.Enabled = false;
            this.comboBoxListaCiudades.FormattingEnabled = true;
            this.comboBoxListaCiudades.Location = new System.Drawing.Point(124, 221);
            this.comboBoxListaCiudades.Name = "comboBoxListaCiudades";
            this.comboBoxListaCiudades.Size = new System.Drawing.Size(121, 21);
            this.comboBoxListaCiudades.TabIndex = 8;
            // 
            // labelAgregarCiudad
            // 
            this.labelAgregarCiudad.AutoSize = true;
            this.labelAgregarCiudad.Location = new System.Drawing.Point(27, 180);
            this.labelAgregarCiudad.Name = "labelAgregarCiudad";
            this.labelAgregarCiudad.Size = new System.Drawing.Size(83, 13);
            this.labelAgregarCiudad.TabIndex = 7;
            this.labelAgregarCiudad.Text = "Agregar Ciudad:";
            // 
            // buttonAgregarCiudad
            // 
            this.buttonAgregarCiudad.Enabled = false;
            this.buttonAgregarCiudad.Location = new System.Drawing.Point(30, 261);
            this.buttonAgregarCiudad.Name = "buttonAgregarCiudad";
            this.buttonAgregarCiudad.Size = new System.Drawing.Size(277, 23);
            this.buttonAgregarCiudad.TabIndex = 6;
            this.buttonAgregarCiudad.Text = "Agregar Ciudad";
            this.buttonAgregarCiudad.UseVisualStyleBackColor = true;
            this.buttonAgregarCiudad.Click += new System.EventHandler(this.Controlador_Click);
            // 
            // FormCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 336);
            this.Controls.Add(this.labelListsaCiudades);
            this.Controls.Add(this.textBoxAgregarCiudad);
            this.Controls.Add(this.comboBoxListaCiudades);
            this.Controls.Add(this.labelAgregarCiudad);
            this.Controls.Add(this.buttonAgregarCiudad);
            this.Controls.Add(this.labelListaProvincias);
            this.Controls.Add(this.textBoxAgregarProvincia);
            this.Controls.Add(this.comboBoxListaProvincias);
            this.Controls.Add(this.labelAgregarProvincia);
            this.Controls.Add(this.buttonAgregarProvincia);
            this.Name = "FormCiudades";
            this.Text = "Ciudades";
            this.Load += new System.EventHandler(this.FormCiudades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAgregarProvincia;
        private System.Windows.Forms.Label labelAgregarProvincia;
        private System.Windows.Forms.ComboBox comboBoxListaProvincias;
        private System.Windows.Forms.TextBox textBoxAgregarProvincia;
        private System.Windows.Forms.Label labelListaProvincias;
        private System.Windows.Forms.Label labelListsaCiudades;
        private System.Windows.Forms.TextBox textBoxAgregarCiudad;
        private System.Windows.Forms.ComboBox comboBoxListaCiudades;
        private System.Windows.Forms.Label labelAgregarCiudad;
        private System.Windows.Forms.Button buttonAgregarCiudad;
    }
}

