namespace WindowsFormsApp2
{
    partial class AgregarPoke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPoke));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDescrip = new System.Windows.Forms.TextBox();
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.ComboDebilidad = new System.Windows.Forms.ComboBox();
            this.Tipo = new System.Windows.Forms.Label();
            this.Debilidad = new System.Windows.Forms.Label();
            this.TxtImagen = new System.Windows.Forms.TextBox();
            this.UrlImagen = new System.Windows.Forms.Label();
            this.PtbUrlImagen = new System.Windows.Forms.PictureBox();
            this.BtnAgegarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtbUrlImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnCancelar, "BtnCancelar");
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Numero
            // 
            resources.ApplyResources(this.Numero, "Numero");
            this.Numero.Name = "Numero";
            // 
            // Nombre
            // 
            resources.ApplyResources(this.Nombre, "Nombre");
            this.Nombre.Name = "Nombre";
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // Descripcion
            // 
            resources.ApplyResources(this.Descripcion, "Descripcion");
            this.Descripcion.Name = "Descripcion";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.TxtNumero, "TxtNumero");
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.TextChanged += new System.EventHandler(this.TxtNumero_TextChanged);
            // 
            // TxtNombre
            // 
            resources.ApplyResources(this.TxtNombre, "TxtNombre");
            this.TxtNombre.Name = "TxtNombre";
            // 
            // TxtDescrip
            // 
            resources.ApplyResources(this.TxtDescrip, "TxtDescrip");
            this.TxtDescrip.Name = "TxtDescrip";
            // 
            // ComboTipo
            // 
            this.ComboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTipo.FormattingEnabled = true;
            resources.ApplyResources(this.ComboTipo, "ComboTipo");
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.SelectedIndexChanged += new System.EventHandler(this.ComboTipo_SelectedIndexChanged);
            // 
            // ComboDebilidad
            // 
            this.ComboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboDebilidad.FormattingEnabled = true;
            resources.ApplyResources(this.ComboDebilidad, "ComboDebilidad");
            this.ComboDebilidad.Name = "ComboDebilidad";
            this.ComboDebilidad.SelectedIndexChanged += new System.EventHandler(this.ComboDebilidad_SelectedIndexChanged);
            // 
            // Tipo
            // 
            resources.ApplyResources(this.Tipo, "Tipo");
            this.Tipo.Name = "Tipo";
            // 
            // Debilidad
            // 
            resources.ApplyResources(this.Debilidad, "Debilidad");
            this.Debilidad.Name = "Debilidad";
            this.Debilidad.Click += new System.EventHandler(this.Debilidad_Click);
            // 
            // TxtImagen
            // 
            resources.ApplyResources(this.TxtImagen, "TxtImagen");
            this.TxtImagen.Name = "TxtImagen";
            this.TxtImagen.Leave += new System.EventHandler(this.TxtImagen_Leave);
            // 
            // UrlImagen
            // 
            resources.ApplyResources(this.UrlImagen, "UrlImagen");
            this.UrlImagen.Name = "UrlImagen";
            // 
            // PtbUrlImagen
            // 
            resources.ApplyResources(this.PtbUrlImagen, "PtbUrlImagen");
            this.PtbUrlImagen.Name = "PtbUrlImagen";
            this.PtbUrlImagen.TabStop = false;
            // 
            // BtnAgegarImagen
            // 
            resources.ApplyResources(this.BtnAgegarImagen, "BtnAgegarImagen");
            this.BtnAgegarImagen.Name = "BtnAgegarImagen";
            this.BtnAgegarImagen.UseVisualStyleBackColor = true;
            this.BtnAgegarImagen.Click += new System.EventHandler(this.BtnAgegarImagen_Click);
            // 
            // AgregarPoke
            // 
            this.AcceptButton = this.btnAceptar;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            resources.ApplyResources(this, "$this");
            this.CancelButton = this.BtnCancelar;
            this.Controls.Add(this.BtnAgegarImagen);
            this.Controls.Add(this.PtbUrlImagen);
            this.Controls.Add(this.TxtImagen);
            this.Controls.Add(this.UrlImagen);
            this.Controls.Add(this.Debilidad);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.ComboDebilidad);
            this.Controls.Add(this.ComboTipo);
            this.Controls.Add(this.TxtDescrip);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtNumero);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AgregarPoke";
            this.Load += new System.EventHandler(this.AgregarPoke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtbUrlImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDescrip;
        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.ComboBox ComboDebilidad;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Debilidad;
        private System.Windows.Forms.TextBox TxtImagen;
        private System.Windows.Forms.Label UrlImagen;
        private System.Windows.Forms.PictureBox PtbUrlImagen;
        private System.Windows.Forms.Button BtnAgegarImagen;
    }
}