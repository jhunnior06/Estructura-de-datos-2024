namespace Laboratorio_8._17
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
            txtAgregarPalabras = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarPalabras = new Button();
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente = new Button();
            btnSalir = new Button();
            txtLongitudPalabra = new TextBox();
            lblLongitudPalabra = new Label();
            SuspendLayout();
            // 
            // txtAgregarPalabras
            // 
            txtAgregarPalabras.Location = new Point(12, 15);
            txtAgregarPalabras.Name = "txtAgregarPalabras";
            txtAgregarPalabras.Size = new Size(259, 27);
            txtAgregarPalabras.TabIndex = 113;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(441, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 112;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(441, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 115;
            // 
            // btnAgregarPalabras
            // 
            btnAgregarPalabras.Location = new Point(12, 48);
            btnAgregarPalabras.Name = "btnAgregarPalabras";
            btnAgregarPalabras.Size = new Size(259, 29);
            btnAgregarPalabras.TabIndex = 114;
            btnAgregarPalabras.Text = "Agregar Palabras";
            btnAgregarPalabras.UseVisualStyleBackColor = true;
            // 
            // btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente
            // 
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Location = new Point(1, 272);
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Name = "btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente";
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Size = new Size(434, 45);
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.TabIndex = 111;
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Text = "Palabras Con Logetud Determinada En Ordenados Ascendente";
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 367);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 110;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtLongitudPalabra
            // 
            txtLongitudPalabra.Location = new Point(12, 130);
            txtLongitudPalabra.Name = "txtLongitudPalabra";
            txtLongitudPalabra.Size = new Size(259, 27);
            txtLongitudPalabra.TabIndex = 116;
            // 
            // lblLongitudPalabra
            // 
            lblLongitudPalabra.AutoSize = true;
            lblLongitudPalabra.Location = new Point(12, 107);
            lblLongitudPalabra.Name = "lblLongitudPalabra";
            lblLongitudPalabra.Size = new Size(170, 20);
            lblLongitudPalabra.TabIndex = 117;
            lblLongitudPalabra.Text = "Longitud de las Palabras";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLongitudPalabra);
            Controls.Add(txtLongitudPalabra);
            Controls.Add(txtAgregarPalabras);
            Controls.Add(txtLista1);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarPalabras);
            Controls.Add(btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAgregarPalabras;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAgregarPalabras;
        private Button btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente;
        private Button btnSalir;
        private TextBox txtLongitudPalabra;
        private Label lblLongitudPalabra;
    }
}
