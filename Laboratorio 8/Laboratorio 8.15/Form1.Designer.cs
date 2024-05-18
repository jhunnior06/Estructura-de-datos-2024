namespace Laboratorio_8._15
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
            txtAgregarNumero = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarNumero = new Button();
            btnNumerosPrimosOrdenadosAscendente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtAgregarNumero
            // 
            txtAgregarNumero.Location = new Point(35, 61);
            txtAgregarNumero.Name = "txtAgregarNumero";
            txtAgregarNumero.Size = new Size(259, 27);
            txtAgregarNumero.TabIndex = 101;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(403, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 100;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(403, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 103;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(35, 94);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(259, 29);
            btnAgregarNumero.TabIndex = 102;
            btnAgregarNumero.Text = "Agregar Número";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // btnNumerosPrimosOrdenadosAscendente
            // 
            btnNumerosPrimosOrdenadosAscendente.Location = new Point(35, 274);
            btnNumerosPrimosOrdenadosAscendente.Name = "btnNumerosPrimosOrdenadosAscendente";
            btnNumerosPrimosOrdenadosAscendente.Size = new Size(335, 29);
            btnNumerosPrimosOrdenadosAscendente.TabIndex = 99;
            btnNumerosPrimosOrdenadosAscendente.Text = "Numeros Primos Ordenados de Menor a Mayor ";
            btnNumerosPrimosOrdenadosAscendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(35, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 98;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAgregarNumero);
            Controls.Add(txtLista1);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarNumero);
            Controls.Add(btnNumerosPrimosOrdenadosAscendente);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAgregarNumero;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAgregarNumero;
        private Button btnNumerosPrimosOrdenadosAscendente;
        private Button btnSalir;
    }
}
