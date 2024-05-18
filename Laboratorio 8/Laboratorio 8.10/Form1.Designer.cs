namespace Laboratorio_8._10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtEncontrarPalabrasPorLetra;
        private TextBox txtLista2;
        private Button btnAgregarPalabra;
        private TextBox txtAgregarPalabra;
        private TextBox txtLista1;
        private Button btnEncontrarPalabrasPorLetra;
        private Button btnSalir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtEncontrarPalabrasPorLetra = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarPalabra = new Button();
            txtAgregarPalabra = new TextBox();
            txtLista1 = new TextBox();
            btnEncontrarPalabrasPorLetra = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtEncontrarPalabrasPorLetra
            // 
            txtEncontrarPalabrasPorLetra.Location = new Point(111, 241);
            txtEncontrarPalabrasPorLetra.Name = "txtEncontrarPalabrasPorLetra";
            txtEncontrarPalabrasPorLetra.Size = new Size(259, 27);
            txtEncontrarPalabrasPorLetra.TabIndex = 73;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(403, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 79;
            // 
            // btnAgregarPalabra
            // 
            btnAgregarPalabra.Location = new Point(111, 126);
            btnAgregarPalabra.Name = "btnAgregarPalabra";
            btnAgregarPalabra.Size = new Size(259, 29);
            btnAgregarPalabra.TabIndex = 78;
            btnAgregarPalabra.Text = "Agregar Palabra";
            btnAgregarPalabra.UseVisualStyleBackColor = true;
            // 
            // txtAgregarPalabra
            // 
            txtAgregarPalabra.Location = new Point(111, 93);
            txtAgregarPalabra.Name = "txtAgregarPalabra";
            txtAgregarPalabra.Size = new Size(259, 27);
            txtAgregarPalabra.TabIndex = 77;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(403, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 76;
            // 
            // btnEncontrarPalabrasPorLetra
            // 
            btnEncontrarPalabrasPorLetra.Location = new Point(111, 274);
            btnEncontrarPalabrasPorLetra.Name = "btnEncontrarPalabrasPorLetra";
            btnEncontrarPalabrasPorLetra.Size = new Size(259, 29);
            btnEncontrarPalabrasPorLetra.TabIndex = 75;
            btnEncontrarPalabrasPorLetra.Text = "Encontrar Palabras Por Letra";
            btnEncontrarPalabrasPorLetra.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(111, 331);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 74;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtEncontrarPalabrasPorLetra);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarPalabra);
            Controls.Add(txtAgregarPalabra);
            Controls.Add(txtLista1);
            Controls.Add(btnEncontrarPalabrasPorLetra);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
