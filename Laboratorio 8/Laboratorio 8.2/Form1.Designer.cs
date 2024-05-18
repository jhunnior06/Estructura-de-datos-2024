namespace Laboratorio_8._2
{
    partial class Form1
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
            this.textFiltrarPalabrasPorLetra = new System.Windows.Forms.TextBox();
            this.txtLista2 = new System.Windows.Forms.TextBox();
            this.btnFiltrarPalabrasPorLetra = new System.Windows.Forms.Button();
            this.txtLista1 = new System.Windows.Forms.TextBox();
            this.btnAgregarPalabras = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textFiltrarPalabrasPorLetra
            // 
            this.textFiltrarPalabrasPorLetra.Location = new System.Drawing.Point(95, 261);
            this.textFiltrarPalabrasPorLetra.Name = "textFiltrarPalabrasPorLetra";
            this.textFiltrarPalabrasPorLetra.Size = new System.Drawing.Size(259, 27);
            this.textFiltrarPalabrasPorLetra.TabIndex = 19;
            // 
            // txtLista2
            // 
            this.txtLista2.Location = new System.Drawing.Point(419, 222);
            this.txtLista2.Multiline = true;
            this.txtLista2.Name = "txtLista2";
            this.txtLista2.Size = new System.Drawing.Size(287, 183);
            this.txtLista2.TabIndex = 18;
            // 
            // btnFiltrarPalabrasPorLetra
            // 
            this.btnFiltrarPalabrasPorLetra.Location = new System.Drawing.Point(95, 294);
            this.btnFiltrarPalabrasPorLetra.Name = "btnFiltrarPalabrasPorLetra";
            this.btnFiltrarPalabrasPorLetra.Size = new System.Drawing.Size(181, 29);
            this.btnFiltrarPalabrasPorLetra.TabIndex = 17;
            this.btnFiltrarPalabrasPorLetra.Text = "Filtrar Palabras Por Letra";
            this.btnFiltrarPalabrasPorLetra.UseVisualStyleBackColor = true;
            this.btnFiltrarPalabrasPorLetra.Click += new System.EventHandler(this.btnFiltrarPalabrasPorLetra_Click);
            // 
            // txtLista1
            // 
            this.txtLista1.Location = new System.Drawing.Point(419, 12);
            this.txtLista1.Multiline = true;
            this.txtLista1.Name = "txtLista1";
            this.txtLista1.Size = new System.Drawing.Size(287, 187);
            this.txtLista1.TabIndex = 16;
            // 
            // btnAgregarPalabras
            // 
            this.btnAgregarPalabras.Location = new System.Drawing.Point(95, 80);
            this.btnAgregarPalabras.Name = "btnAgregarPalabras";
            this.btnAgregarPalabras.Size = new System.Drawing.Size(212, 29);
            this.btnAgregarPalabras.TabIndex = 15;
            this.btnAgregarPalabras.Text = "Agregar Palabras";
            this.btnAgregarPalabras.UseVisualStyleBackColor = true;
            this.btnAgregarPalabras.Click += new System.EventHandler(this.btnAgregarPalabras_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(95, 47);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(259, 27);
            this.txtLetra.TabIndex = 14;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(95, 409);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(94, 29);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textFiltrarPalabrasPorLetra);
            this.Controls.Add(this.txtLista2);
            this.Controls.Add(this.btnFiltrarPalabrasPorLetra);
            this.Controls.Add(this.txtLista1);
            this.Controls.Add(this.btnAgregarPalabras);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.btnsalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textFiltrarPalabrasPorLetra;
        private System.Windows.Forms.TextBox txtLista2;
        private System.Windows.Forms.Button btnFiltrarPalabrasPorLetra;
        private System.Windows.Forms.TextBox txtLista1;
        private System.Windows.Forms.Button btnAgregarPalabras;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnsalir;
    }
}
