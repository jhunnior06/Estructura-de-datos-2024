namespace Laboratorio_8._16
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
            btnPalabrasEnOrdenadosAscendente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtAgregarPalabras
            // 
            txtAgregarPalabras.Location = new Point(73, 61);
            txtAgregarPalabras.Name = "txtAgregarPalabras";
            txtAgregarPalabras.Size = new Size(259, 27);
            txtAgregarPalabras.TabIndex = 107;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(441, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 106;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(441, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 109;
            // 
            // btnAgregarPalabras
            // 
            btnAgregarPalabras.Location = new Point(73, 94);
            btnAgregarPalabras.Name = "btnAgregarPalabras";
            btnAgregarPalabras.Size = new Size(259, 29);
            btnAgregarPalabras.TabIndex = 108;
            btnAgregarPalabras.Text = "Agregar Palabras";
            btnAgregarPalabras.UseVisualStyleBackColor = true;
            // 
            // btnPalabrasEnOrdenadosAscendente
            // 
            btnPalabrasEnOrdenadosAscendente.Location = new Point(73, 272);
            btnPalabrasEnOrdenadosAscendente.Name = "btnPalabrasEnOrdenadosAscendente";
            btnPalabrasEnOrdenadosAscendente.Size = new Size(362, 37);
            btnPalabrasEnOrdenadosAscendente.TabIndex = 105;
            btnPalabrasEnOrdenadosAscendente.Text = "Palabras Palindromos Ordenados de Menor a Mayor ";
            btnPalabrasEnOrdenadosAscendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(73, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 104;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAgregarPalabras);
            Controls.Add(txtLista1);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarPalabras);
            Controls.Add(btnPalabrasEnOrdenadosAscendente);
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
        private Button btnPalabrasEnOrdenadosAscendente;
        private Button btnSalir;
    }
}
