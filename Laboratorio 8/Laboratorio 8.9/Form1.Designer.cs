namespace Laboratorio_8._9
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLista2;
        private Button btnAgregarPalabra;
        private TextBox txtAgregarPalabra;
        private TextBox txtLista1;
        private Button btnEncontrarPalabrasPorLongitud;
        private Button btnSalir;
        private TextBox txtLongitud;

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
            txtLista2 = new TextBox();
            btnAgregarPalabra = new Button();
            txtAgregarPalabra = new TextBox();
            txtLista1 = new TextBox();
            btnEncontrarPalabrasPorLongitud = new Button();
            btnSalir = new Button();
            txtLongitud = new TextBox();
            SuspendLayout();
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(403, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 72;
            // 
            // btnAgregarPalabra
            // 
            btnAgregarPalabra.Location = new Point(111, 126);
            btnAgregarPalabra.Name = "btnAgregarPalabra";
            btnAgregarPalabra.Size = new Size(259, 29);
            btnAgregarPalabra.TabIndex = 71;
            btnAgregarPalabra.Text = "Agregar Palabra";
            btnAgregarPalabra.UseVisualStyleBackColor = true;
            // 
            // txtAgregarPalabra
            // 
            txtAgregarPalabra.Location = new Point(111, 93);
            txtAgregarPalabra.Name = "txtAgregarPalabra";
            txtAgregarPalabra.Size = new Size(259, 27);
            txtAgregarPalabra.TabIndex = 70;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(403, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 69;
            // 
            // btnEncontrarPalabrasPorLongitud
            // 
            btnEncontrarPalabrasPorLongitud.Location = new Point(111, 274);
            btnEncontrarPalabrasPorLongitud.Name = "btnEncontrarPalabrasPorLongitud";
            btnEncontrarPalabrasPorLongitud.Size = new Size(259, 29);
            btnEncontrarPalabrasPorLongitud.TabIndex = 68;
            btnEncontrarPalabrasPorLongitud.Text = "Encontrar Palabras Por Longitud";
            btnEncontrarPalabrasPorLongitud.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(111, 331);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 67;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtLongitud
            // 
            txtLongitud.Location = new Point(111, 241);
            txtLongitud.Name = "txtLongitud";
            txtLongitud.Size = new Size(259, 27);
            txtLongitud.TabIndex = 67;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLongitud);
            Controls.Add(txtLista2);
            Controls.Add(btnAgregarPalabra);
            Controls.Add(txtAgregarPalabra);
            Controls.Add(txtLista1);
            Controls.Add(btnEncontrarPalabrasPorLongitud);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

