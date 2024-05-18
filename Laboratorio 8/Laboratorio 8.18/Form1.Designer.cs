namespace Laboratorio_8._18
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblLetraDeterminada = new Label();
            txtLetraDeterminada = new TextBox();
            txtAgregarPalabras = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarPalabras = new Button();
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblLetraDeterminada
            // 
            lblLetraDeterminada.AutoSize = true;
            lblLetraDeterminada.Location = new Point(48, 107);
            lblLetraDeterminada.Name = "lblLetraDeterminada";
            lblLetraDeterminada.Size = new Size(137, 20);
            lblLetraDeterminada.TabIndex = 125;
            lblLetraDeterminada.Text = "Letra Determinada ";
            // 
            // txtLetraDeterminada
            // 
            txtLetraDeterminada.Location = new Point(48, 130);
            txtLetraDeterminada.Name = "txtLetraDeterminada";
            txtLetraDeterminada.Size = new Size(259, 27);
            txtLetraDeterminada.TabIndex = 124;
            txtLetraDeterminada.KeyPress += txtLetraDeterminada_KeyPress;
            // 
            // txtAgregarPalabras
            // 
            txtAgregarPalabras.Location = new Point(48, 15);
            txtAgregarPalabras.Name = "txtAgregarPalabras";
            txtAgregarPalabras.Size = new Size(259, 27);
            txtAgregarPalabras.TabIndex = 121;
            txtAgregarPalabras.KeyPress += txtAgregarPalabras_KeyPress;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(477, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 120;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(477, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 123;
            // 
            // btnAgregarPalabras
            // 
            btnAgregarPalabras.Location = new Point(48, 48);
            btnAgregarPalabras.Name = "btnAgregarPalabras";
            btnAgregarPalabras.Size = new Size(259, 29);
            btnAgregarPalabras.TabIndex = 122;
            btnAgregarPalabras.Text = "Agregar Palabras";
            btnAgregarPalabras.UseVisualStyleBackColor = true;
            btnAgregarPalabras.Click += BtnAgregarPalabras_Click;
            // 
            // btnPalabrasConLetraDeterminadaEnOrdenadosDescendente
            // 
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.Location = new Point(37, 272);
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.Name = "btnPalabrasConLetraDeterminadaEnOrdenadosDescendente";
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.Size = new Size(270, 55);
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.TabIndex = 119;
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.Text = "Palabras Con Letra Determinada Ordenados de Mayor a Menor";
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.UseVisualStyleBackColor = true;
            btnPalabrasConLetraDeterminadaEnOrdenadosDescendente.Click += BtnPalabrasConLetraDeterminadaEnOrdenadosDescendente_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(48, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 118;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLetraDeterminada);
            Controls.Add(txtLetraDeterminada);
            Controls.Add(txtAgregarPalabras);
            Controls.Add(txtLista1);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarPalabras);
            Controls.Add(btnPalabrasConLetraDeterminadaEnOrdenadosDescendente);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblLetraDeterminada;
        private System.Windows.Forms.TextBox txtLetraDeterminada;
        private System.Windows.Forms.TextBox txtAgregarPalabras;
        private System.Windows.Forms.TextBox txtLista1;
        private System.Windows.Forms.TextBox txtLista2;
        private System.Windows.Forms.Button btnAgregarPalabras;
        private System.Windows.Forms.Button btnPalabrasConLetraDeterminadaEnOrdenadosDescendente;
        private System.Windows.Forms.Button btnSalir;
    }
}
