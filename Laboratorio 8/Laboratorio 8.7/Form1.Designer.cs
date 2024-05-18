namespace Laboratorio_8._7
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
            this.txtLista2 = new System.Windows.Forms.TextBox();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.txtAgregarPalabra = new System.Windows.Forms.TextBox();
            this.txtLista1 = new System.Windows.Forms.TextBox();
            this.btnEncontrarAnagramas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLista2
            // 
            this.txtLista2.Location = new System.Drawing.Point(403, 248);
            this.txtLista2.Multiline = true;
            this.txtLista2.Name = "txtLista2";
            this.txtLista2.ReadOnly = true;
            this.txtLista2.Size = new System.Drawing.Size(287, 145);
            this.txtLista2.TabIndex = 60;
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Location = new System.Drawing.Point(111, 126);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(259, 29);
            this.btnAgregarPalabra.TabIndex = 59;
            this.btnAgregarPalabra.Text = "Agregar Palabras";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            // 
            // txtAgregarPalabra
            // 
            this.txtAgregarPalabra.Location = new System.Drawing.Point(111, 93);
            this.txtAgregarPalabra.Name = "txtAgregarPalabra";
            this.txtAgregarPalabra.Size = new System.Drawing.Size(259, 27);
            this.txtAgregarPalabra.TabIndex = 58;
            // 
            // txtLista1
            // 
            this.txtLista1.Location = new System.Drawing.Point(403, 76);
            this.txtLista1.Multiline = true;
            this.txtLista1.Name = "txtLista1";
            this.txtLista1.ReadOnly = true;
            this.txtLista1.Size = new System.Drawing.Size(287, 153);
            this.txtLista1.TabIndex = 57;
            // 
            // btnEncontrarAnagramas
            // 
            this.btnEncontrarAnagramas.Location = new System.Drawing.Point(111, 274);
            this.btnEncontrarAnagramas.Name = "btnEncontrarAnagramas";
            this.btnEncontrarAnagramas.Size = new System.Drawing.Size(259, 29);
            this.btnEncontrarAnagramas.TabIndex = 56;
            this.btnEncontrarAnagramas.Text = "Encontrar Anagramas";
            this.btnEncontrarAnagramas.UseVisualStyleBackColor = true;
            this.btnEncontrarAnagramas.Click += new System.EventHandler(this.btnEncontrarAnagramas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(111, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLista2);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.txtAgregarPalabra);
            this.Controls.Add(this.txtLista1);
            this.Controls.Add(this.btnEncontrarAnagramas);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLista2;
        private System.Windows.Forms.Button btnAgregarPalabra;
        private System.Windows.Forms.TextBox txtAgregarPalabra;
        private System.Windows.Forms.TextBox txtLista1;
        private System.Windows.Forms.Button btnEncontrarAnagramas;
        private System.Windows.Forms.Button btnSalir;
    }
}

