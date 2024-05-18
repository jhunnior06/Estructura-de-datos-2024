namespace Laboratorio_7._2
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
            lblAñosAntigüedad = new Label();
            textBox1 = new TextBox();
            lblArea = new Label();
            cmbArea = new ComboBox();
            lblCargo = new Label();
            cmbCargo = new ComboBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnMostrar = new Button();
            btnCrearObjeto = new Button();
            txtResultado = new TextBox();
            lblDni = new Label();
            textDni = new TextBox();
            lblNombres = new Label();
            textNombres = new TextBox();
            SuspendLayout();
            // 
            // lblAñosAntigüedad
            // 
            lblAñosAntigüedad.AutoSize = true;
            lblAñosAntigüedad.Location = new Point(12, 74);
            lblAñosAntigüedad.Name = "lblAñosAntigüedad";
            lblAñosAntigüedad.Size = new Size(145, 20);
            lblAñosAntigüedad.TabIndex = 59;
            lblAñosAntigüedad.Text = "Años de Antigüedad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 97);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 58;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(609, 4);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 57;
            lblArea.Text = "Area";
            // 
            // cmbArea
            // 
            cmbArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArea.FormattingEnabled = true;
            cmbArea.Items.AddRange(new object[] { "CONTABILIDAD ", "PLANIFICACION" });
            cmbArea.Location = new Point(609, 27);
            cmbArea.Name = "cmbArea";
            cmbArea.Size = new Size(190, 28);
            cmbArea.TabIndex = 56;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(413, 5);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(49, 20);
            lblCargo.TabIndex = 55;
            lblCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "GERENTE ", "SUBGERENTE" });
            cmbCargo.Location = new Point(413, 28);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(190, 28);
            cmbCargo.TabIndex = 54;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(498, 417);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 29);
            btnLimpiar.TabIndex = 53;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(644, 417);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 29);
            btnSalir.TabIndex = 52;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(215, 417);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(258, 29);
            btnMostrar.TabIndex = 51;
            btnMostrar.Text = "Mostrar Informacion del Objeto";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnCrearObjeto
            // 
            btnCrearObjeto.Location = new Point(1, 417);
            btnCrearObjeto.Name = "btnCrearObjeto";
            btnCrearObjeto.Size = new Size(123, 29);
            btnCrearObjeto.TabIndex = 50;
            btnCrearObjeto.Text = "Crear Objeto";
            btnCrearObjeto.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.Control;
            txtResultado.ForeColor = SystemColors.WindowText;
            txtResultado.Location = new Point(1, 130);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(787, 281);
            txtResultado.TabIndex = 49;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(282, 4);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 48;
            lblDni.Text = "DNI";
            // 
            // textDni
            // 
            textDni.Location = new Point(282, 27);
            textDni.Name = "textDni";
            textDni.Size = new Size(125, 27);
            textDni.TabIndex = 47;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(12, 5);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 46;
            lblNombres.Text = "Nombres";
            // 
            // textNombres
            // 
            textNombres.Location = new Point(12, 28);
            textNombres.Name = "textNombres";
            textNombres.Size = new Size(264, 27);
            textNombres.TabIndex = 45;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAñosAntigüedad);
            Controls.Add(textBox1);
            Controls.Add(lblArea);
            Controls.Add(cmbArea);
            Controls.Add(lblCargo);
            Controls.Add(cmbCargo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrearObjeto);
            Controls.Add(txtResultado);
            Controls.Add(lblDni);
            Controls.Add(textDni);
            Controls.Add(lblNombres);
            Controls.Add(textNombres);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAñosAntigüedad;
        private TextBox textBox1;
        private Label lblArea;
        private ComboBox cmbArea;
        private Label lblCargo;
        private ComboBox cmbCargo;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnMostrar;
        private Button btnCrearObjeto;
        private TextBox txtResultado;
        private Label lblDni;
        private TextBox textDni;
        private Label lblNombres;
        private TextBox textNombres;
    }
}
