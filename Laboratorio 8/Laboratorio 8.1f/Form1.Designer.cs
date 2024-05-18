namespace Laboratorio_8._1f
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
            txtLista2 = new TextBox();
            btnPrimos = new Button();
            txtLista1 = new TextBox();
            btnAgregarNumero = new Button();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(352, 246);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(287, 159);
            txtLista2.TabIndex = 10;
            // 
            // btnPrimos
            // 
            btnPrimos.Location = new Point(162, 292);
            btnPrimos.Name = "btnPrimos";
            btnPrimos.Size = new Size(131, 29);
            btnPrimos.TabIndex = 9;
            btnPrimos.Text = "Buscar Primos";
            btnPrimos.UseVisualStyleBackColor = true;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(352, 22);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(287, 159);
            txtLista1.TabIndex = 8;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(162, 91);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(131, 29);
            btnAgregarNumero.TabIndex = 7;
            btnAgregarNumero.Text = "Agregar Numero";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(162, 47);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLista2);
            Controls.Add(btnPrimos);
            Controls.Add(txtLista1);
            Controls.Add(btnAgregarNumero);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLista2;
        private Button btnPrimos;
        private TextBox txtLista1;
        private Button btnAgregarNumero;
        private TextBox txtNumero;
    }
}
