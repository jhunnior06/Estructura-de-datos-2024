namespace Laboratorio8._20
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
            lblLungitudDeterminada = new Label();
            txtLetraDeterminada = new TextBox();
            txtAgregarPalabras = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarPalabras = new Button();
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblLungitudDeterminada
            // 
            lblLungitudDeterminada.AutoSize = true;
            lblLungitudDeterminada.Location = new Point(48, 107);
            lblLungitudDeterminada.Name = "lblLungitudDeterminada";
            lblLungitudDeterminada.Size = new Size(146, 20);
            lblLungitudDeterminada.TabIndex = 133;
            lblLungitudDeterminada.Text = "Lungitud Determida ";
            // 
            // txtLetraDeterminada
            // 
            txtLetraDeterminada.Location = new Point(48, 130);
            txtLetraDeterminada.Name = "txtLetraDeterminada";
            txtLetraDeterminada.Size = new Size(259, 27);
            txtLetraDeterminada.TabIndex = 132;
            // 
            // txtAgregarPalabras
            // 
            txtAgregarPalabras.Location = new Point(48, 15);
            txtAgregarPalabras.Name = "txtAgregarPalabras";
            txtAgregarPalabras.Size = new Size(259, 27);
            txtAgregarPalabras.TabIndex = 129;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(477, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 128;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(477, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 131;
            // 
            // btnAgregarPalabras
            // 
            btnAgregarPalabras.Location = new Point(48, 48);
            btnAgregarPalabras.Name = "btnAgregarPalabras";
            btnAgregarPalabras.Size = new Size(259, 29);
            btnAgregarPalabras.TabIndex = 130;
            btnAgregarPalabras.Text = "Agregar Palabras";
            btnAgregarPalabras.UseVisualStyleBackColor = true;
            // 
            // btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente
            // 
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.Location = new Point(37, 272);
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.Name = "btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente";
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.Size = new Size(328, 55);
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.TabIndex = 127;
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.Text = "Palabras Palindromos Con Lungitudes Determinadas Ordenados de Menor a Mayor";
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(48, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 126;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLungitudDeterminada);
            Controls.Add(txtLetraDeterminada);
            Controls.Add(txtAgregarPalabras);
            Controls.Add(txtLista1);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarPalabras);
            Controls.Add(btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLungitudDeterminada;
        private TextBox txtLetraDeterminada;
        private TextBox txtAgregarPalabras;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAgregarPalabras;
        private Button btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente;
        private Button btnSalir;
    }
}
