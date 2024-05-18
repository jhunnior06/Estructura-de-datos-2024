namespace Laboratorio_8._3
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
            textFiltrarPorDivisivilidad = new TextBox();
            txtLista2 = new TextBox();
            btnFiltrarPorDivisivilidad = new Button();
            txtLista1 = new TextBox();
            btnAgregarNumeros = new Button();
            txtAgregarNumero = new TextBox();
            btnsalir = new Button();
            SuspendLayout();
            // 
            // textFiltrarPorDivisivilidad
            // 
            textFiltrarPorDivisivilidad.Location = new Point(95, 261);
            textFiltrarPorDivisivilidad.Name = "textFiltrarPorDivisivilidad";
            textFiltrarPorDivisivilidad.Size = new Size(259, 27);
            textFiltrarPorDivisivilidad.TabIndex = 26;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(419, 222);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 25;
            // 
            // btnFiltrarPorDivisivilidad
            // 
            btnFiltrarPorDivisivilidad.Location = new Point(95, 294);
            btnFiltrarPorDivisivilidad.Name = "btnFiltrarPorDivisivilidad";
            btnFiltrarPorDivisivilidad.Size = new Size(181, 29);
            btnFiltrarPorDivisivilidad.TabIndex = 24;
            btnFiltrarPorDivisivilidad.Text = "Filtrar Por Divisivilidad";
            btnFiltrarPorDivisivilidad.UseVisualStyleBackColor = true;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(419, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(287, 187);
            txtLista1.TabIndex = 23;
            // 
            // btnAgregarNumeros
            // 
            btnAgregarNumeros.Location = new Point(95, 80);
            btnAgregarNumeros.Name = "btnAgregarNumeros";
            btnAgregarNumeros.Size = new Size(212, 29);
            btnAgregarNumeros.TabIndex = 22;
            btnAgregarNumeros.Text = "Agregar Numeros";
            btnAgregarNumeros.UseVisualStyleBackColor = true;
            // 
            // txtAgregarNumero
            // 
            txtAgregarNumero.Location = new Point(95, 47);
            txtAgregarNumero.Name = "txtAgregarNumero";
            txtAgregarNumero.Size = new Size(259, 27);
            txtAgregarNumero.TabIndex = 21;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(95, 409);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(94, 29);
            btnsalir.TabIndex = 20;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textFiltrarPorDivisivilidad);
            Controls.Add(txtLista2);
            Controls.Add(btnFiltrarPorDivisivilidad);
            Controls.Add(txtLista1);
            Controls.Add(btnAgregarNumeros);
            Controls.Add(txtAgregarNumero);
            Controls.Add(btnsalir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textFiltrarPorDivisivilidad;
        private TextBox txtLista2;
        private Button btnFiltrarPorDivisivilidad;
        private TextBox txtLista1;
        private Button btnAgregarNumeros;
        private TextBox txtAgregarNumero;
        private Button btnsalir;
    }
}
