namespace Laboratorio_7._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipoAfiliacion = new Label();
            cmbTipoAfiliacion = new ComboBox();
            lblTipoActividad = new Label();
            cmbTipoActividad = new ComboBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnMostrar = new Button();
            btnCrearObjeto = new Button();
            txtResultado = new TextBox();
            lblEspecialidad = new Label();
            cmbEspecialidad = new ComboBox();
            lblCondicionContrato = new Label();
            cmbCondicionContrato = new ComboBox();
            txtNombres = new TextBox();
            lblNombres = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // lblTipoAfiliacion
            // 
            lblTipoAfiliacion.AutoSize = true;
            lblTipoAfiliacion.Location = new Point(218, 62);
            lblTipoAfiliacion.Name = "lblTipoAfiliacion";
            lblTipoAfiliacion.Size = new Size(127, 20);
            lblTipoAfiliacion.TabIndex = 54;
            lblTipoAfiliacion.Text = "Tipo de Afiliacion";
            // 
            // cmbTipoAfiliacion
            // 
            cmbTipoAfiliacion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoAfiliacion.FormattingEnabled = true;
            cmbTipoAfiliacion.Items.AddRange(new object[] { "AFP", "SNP" });
            cmbTipoAfiliacion.Location = new Point(218, 85);
            cmbTipoAfiliacion.Name = "cmbTipoAfiliacion";
            cmbTipoAfiliacion.Size = new Size(111, 28);
            cmbTipoAfiliacion.TabIndex = 53;
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(0, 62);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(127, 20);
            lblTipoActividad.TabIndex = 52;
            lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // cmbTipoActividad
            // 
            cmbTipoActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoActividad.FormattingEnabled = true;
            cmbTipoActividad.Items.AddRange(new object[] { "SUPERVISION DE OBRAS", "SUPERVISION DE VIAS" });
            cmbTipoActividad.Location = new Point(0, 85);
            cmbTipoActividad.Name = "cmbTipoActividad";
            cmbTipoActividad.Size = new Size(208, 28);
            cmbTipoActividad.TabIndex = 51;
            cmbTipoActividad.Tag = "cmbTipoActividad";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(501, 419);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 29);
            btnLimpiar.TabIndex = 50;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(647, 419);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 29);
            btnSalir.TabIndex = 49;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(218, 419);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(258, 29);
            btnMostrar.TabIndex = 48;
            btnMostrar.Text = "Mostrar Informacion del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnCrearObjeto
            // 
            btnCrearObjeto.Location = new Point(4, 419);
            btnCrearObjeto.Name = "btnCrearObjeto";
            btnCrearObjeto.Size = new Size(123, 29);
            btnCrearObjeto.TabIndex = 47;
            btnCrearObjeto.Text = "Crear Objeto";
            btnCrearObjeto.UseVisualStyleBackColor = true;
            btnCrearObjeto.Click += btnCrearObjeto_Click;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Control;
            txtResultado.ForeColor = SystemColors.WindowText;
            txtResultado.Location = new Point(4, 132);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(797, 281);
            txtResultado.TabIndex = 46;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(547, 62);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 45;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Items.AddRange(new object[] { "ESTRUCTURAS", "RECURSOS HÍDRICOS" });
            cmbEspecialidad.Location = new Point(547, 85);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(190, 28);
            cmbEspecialidad.TabIndex = 44;
            // 
            // lblCondicionContrato
            // 
            lblCondicionContrato.AutoSize = true;
            lblCondicionContrato.Location = new Point(545, 3);
            lblCondicionContrato.Name = "lblCondicionContrato";
            lblCondicionContrato.Size = new Size(159, 20);
            lblCondicionContrato.TabIndex = 43;
            lblCondicionContrato.Text = "Condicion de Contrato";
            // 
            // cmbCondicionContrato
            // 
            cmbCondicionContrato.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCondicionContrato.FormattingEnabled = true;
            cmbCondicionContrato.Items.AddRange(new object[] { "ESTABLE", "CONTRATADO" });
            cmbCondicionContrato.Location = new Point(547, 25);
            cmbCondicionContrato.Name = "cmbCondicionContrato";
            cmbCondicionContrato.Size = new Size(190, 28);
            cmbCondicionContrato.TabIndex = 42;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(218, 25);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(313, 27);
            txtNombres.TabIndex = 41;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(218, 3);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 40;
            lblNombres.Text = "Nombres";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(0, 26);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(167, 27);
            txtCodigo.TabIndex = 39;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(0, 3);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 38;
            lblCodigo.Text = "Codigo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoAfiliacion);
            Controls.Add(cmbTipoAfiliacion);
            Controls.Add(lblTipoActividad);
            Controls.Add(cmbTipoActividad);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrearObjeto);
            Controls.Add(txtResultado);
            Controls.Add(lblEspecialidad);
            Controls.Add(cmbEspecialidad);
            Controls.Add(lblCondicionContrato);
            Controls.Add(cmbCondicionContrato);
            Controls.Add(txtNombres);
            Controls.Add(lblNombres);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoAfiliacion;
        private ComboBox cmbTipoAfiliacion;
        private Label lblTipoActividad;
        private ComboBox cmbTipoActividad;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnMostrar;
        private Button btnCrearObjeto;
        private TextBox txtResultado;
        private Label lblEspecialidad;
        private ComboBox cmbEspecialidad;
        private Label lblCondicionContrato;
        private ComboBox cmbCondicionContrato;
        private TextBox txtNombres;
        private Label lblNombres;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}
