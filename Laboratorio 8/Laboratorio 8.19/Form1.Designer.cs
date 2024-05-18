namespace Laboratorio_8._19
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
            txtAgregarNumeros = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarNumeros = new Button();
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtAgregarNumeros
            // 
            txtAgregarNumeros.Location = new Point(48, 15);
            txtAgregarNumeros.Name = "txtAgregarNumeros";
            txtAgregarNumeros.Size = new Size(259, 27);
            txtAgregarNumeros.TabIndex = 129;
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
            // btnAgregarNumeros
            // 
            btnAgregarNumeros.Location = new Point(48, 48);
            btnAgregarNumeros.Name = "btnAgregarNumeros";
            btnAgregarNumeros.Size = new Size(259, 29);
            btnAgregarNumeros.TabIndex = 130;
            btnAgregarNumeros.Text = "Agregar Numeros";
            btnAgregarNumeros.UseVisualStyleBackColor = true;
            // 
            // btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente
            // 
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Location = new Point(37, 272);
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Name = "btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente";
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Size = new Size(434, 45);
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.TabIndex = 127;
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Text = "Numeros Ordenados de Menor a Mayor sin Duplicidad";
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.UseVisualStyleBackColor = true;
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
            Controls.Add(txtAgregarNumeros);
            Controls.Add(txtLista1);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarNumeros);
            Controls.Add(btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAgregarNumeros;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAgregarNumeros;
        private Button btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente;
        private Button btnSalir;
    }
}
