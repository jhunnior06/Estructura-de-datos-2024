namespace Laboratorio_8._1
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
            this.txtLista2 = new System.Windows.Forms.TextBox();
            this.btnBuscarPrimos = new System.Windows.Forms.Button();
            this.txtLista1 = new System.Windows.Forms.TextBox();
            this.btnAgregarNumero = new System.Windows.Forms.Button();
            this.txtAgregarNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtLista2
            // 
            this.txtLista2.Location = new System.Drawing.Point(352, 246);
            this.txtLista2.Multiline = true;
            this.txtLista2.Name = "txtLista2";
            this.txtLista2.Size = new System.Drawing.Size(287, 159);
            this.txtLista2.TabIndex = 10;
            // 
            // btnBuscarPrimos
            // 
            this.btnBuscarPrimos.Location = new System.Drawing.Point(162, 292);
            this.btnBuscarPrimos.Name = "btnBuscarPrimos";
            this.btnBuscarPrimos.Size = new System.Drawing.Size(131, 29);
            this.btnBuscarPrimos.TabIndex = 9;
            this.btnBuscarPrimos.Text = "Buscar Primos";
            this.btnBuscarPrimos.UseVisualStyleBackColor = true;
            this.btnBuscarPrimos.Click += new System.EventHandler(this.btnBuscarPrimos_Click);
            // 
            // txtLista1
            // 
            this.txtLista1.Location = new System.Drawing.Point(352, 45);
            this.txtLista1.Multiline = true;
            this.txtLista1.Name = "txtLista1";
            this.txtLista1.Size = new System.Drawing.Size(287, 159);
            this.txtLista1.TabIndex = 8;
            // 
            // btnAgregarNumero
            // 
            this.btnAgregarNumero.Location = new System.Drawing.Point(162, 91);
            this.btnAgregarNumero.Name = "btnAgregarNumero";
            this.btnAgregarNumero.Size = new System.Drawing.Size(131, 29);
            this.btnAgregarNumero.TabIndex = 7;
            this.btnAgregarNumero.Text = "Agregar Numero";
            this.btnAgregarNumero.UseVisualStyleBackColor = true;
            this.btnAgregarNumero.Click += new System.EventHandler(this.btnAgregarNumero_Click);
            // 
            // txtAgregarNumero
            // 
            this.txtAgregarNumero.Location = new System.Drawing.Point(162, 47);
            this.txtAgregarNumero.Name = "txtAgregarNumero";
            this.txtAgregarNumero.Size = new System.Drawing.Size(125, 27);
            this.txtAgregarNumero.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLista2);
            this.Controls.Add(this.btnBuscarPrimos);
            this.Controls.Add(this.txtLista1);
            this.Controls.Add(this.btnAgregarNumero);
            this.Controls.Add(this.txtAgregarNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtLista2;
        private System.Windows.Forms.Button btnBuscarPrimos;
        private System.Windows.Forms.TextBox txtLista1;
        private System.Windows.Forms.Button btnAgregarNumero;
        private System.Windows.Forms.TextBox txtAgregarNumero;
    }
}
