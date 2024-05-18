namespace Laboratorio8
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
            txtNumero = new TextBox();
            btnAgregarNumero = new Button();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnPrimos = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(259, 32);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(259, 76);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(131, 29);
            btnAgregarNumero.TabIndex = 2;
            btnAgregarNumero.Text = "Agregar Numero";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(449, 30);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(287, 159);
            txtLista1.TabIndex = 3;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(449, 231);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(287, 159);
            txtLista2.TabIndex = 5;
            // 
            // btnPrimos
            // 
            btnPrimos.Location = new Point(259, 277);
            btnPrimos.Name = "btnPrimos";
            btnPrimos.Size = new Size(131, 29);
            btnPrimos.TabIndex = 4;
            btnPrimos.Text = "Buscar Primos";
            btnPrimos.UseVisualStyleBackColor = true;
            btnPrimos.Click += btnPrimos_Click;
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
        private TextBox txtNumero;
        private Button btnAgregarNumero;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnPrimos;
    }
}
