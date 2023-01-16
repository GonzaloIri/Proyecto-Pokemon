namespace WindowsFormsApp2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.DGVPokemon = new System.Windows.Forms.DataGridView();
            this.PBPokemon = new System.Windows.Forms.PictureBox();
            this.BTAgregar = new System.Windows.Forms.Button();
            this.BTModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Btnbuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVPokemon
            // 
            resources.ApplyResources(this.DGVPokemon, "DGVPokemon");
            this.DGVPokemon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGVPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVPokemon.Name = "DGVPokemon";
            this.DGVPokemon.RowTemplate.Height = 24;
            this.DGVPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPokemon.SelectionChanged += new System.EventHandler(this.DGVPokemon_SelectionChanged);
            this.DGVPokemon.Click += new System.EventHandler(this.DGVPokemon_SelectionChanged);
            // 
            // PBPokemon
            // 
            this.PBPokemon.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.PBPokemon, "PBPokemon");
            this.PBPokemon.Name = "PBPokemon";
            this.PBPokemon.TabStop = false;
            this.PBPokemon.SizeChanged += new System.EventHandler(this.Form3_Load_1);
            this.PBPokemon.Click += new System.EventHandler(this.DGVPokemon_SelectionChanged);
            // 
            // BTAgregar
            // 
            resources.ApplyResources(this.BTAgregar, "BTAgregar");
            this.BTAgregar.Name = "BTAgregar";
            this.BTAgregar.UseVisualStyleBackColor = true;
            this.BTAgregar.Click += new System.EventHandler(this.BTAgregar_Click_1);
            // 
            // BTModificar
            // 
            resources.ApplyResources(this.BTModificar, "BTModificar");
            this.BTModificar.Name = "BTModificar";
            this.BTModificar.UseVisualStyleBackColor = true;
            this.BTModificar.Click += new System.EventHandler(this.BTModificar_Click);
            // 
            // btnEliminar
            // 
            resources.ApplyResources(this.btnEliminar, "btnEliminar");
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // Btnbuscar
            // 
            resources.ApplyResources(this.Btnbuscar, "Btnbuscar");
            this.Btnbuscar.Name = "Btnbuscar";
            this.Btnbuscar.UseVisualStyleBackColor = true;
            this.Btnbuscar.Click += new System.EventHandler(this.Btnbuscar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TxtBuscar
            // 
            resources.ApplyResources(this.TxtBuscar, "TxtBuscar");
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btnbuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BTModificar);
            this.Controls.Add(this.BTAgregar);
            this.Controls.Add(this.PBPokemon);
            this.Controls.Add(this.DGVPokemon);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.Click += new System.EventHandler(this.DGVPokemon_SelectionChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        
        private System.Windows.Forms.DataGridView DGVPokemon;
        private System.Windows.Forms.PictureBox PBPokemon;
        private System.Windows.Forms.Button BTAgregar;
        private System.Windows.Forms.Button BTModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button Btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBuscar;
    }
}