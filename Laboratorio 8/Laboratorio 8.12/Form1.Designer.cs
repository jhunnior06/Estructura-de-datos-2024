namespace Laboratorio_8._12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtAgregarNumero;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAgregarNumero;
        private Button btnOrdenarNumerosDescendente;
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
            txtAgregarNumero = new TextBox();
            txtLista1 = new TextBox();
            txtLista2 = new TextBox();
            btnAgregarNumero = new Button();
            btnOrdenarNumerosDescendente = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtAgregarNumero
            // 
            txtAgregarNumero.Location = new Point(111, 93);
            txtAgregarNumero.Name = "txtAgregarNumero";
            txtAgregarNumero.Size = new Size(259, 27);
            txtAgregarNumero.TabIndex = 83;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(403, 12);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.ReadOnly = true;
            txtLista1.Size = new Size(287, 217);
            txtLista1.TabIndex = 82;
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(403, 255);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.ReadOnly = true;
            txtLista2.Size = new Size(287, 183);
            txtLista2.TabIndex = 85;
            // 
            // btnAgregarNumero
            // 
            btnAgregarNumero.Location = new Point(111, 126);
            btnAgregarNumero.Name = "btnAgregarNumero";
            btnAgregarNumero.Size = new Size(259, 29);
            btnAgregarNumero.TabIndex = 84;
            btnAgregarNumero.Text = "Agregar Número";
            btnAgregarNumero.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarNumerosDescendente
            // 
            btnOrdenarNumerosDescendente.Location = new Point(111, 274);
            btnOrdenarNumerosDescendente.Name = "btnOrdenarNumerosDescendente";
            btnOrdenarNumerosDescendente.Size = new Size(259, 29);
            btnOrdenarNumerosDescendente.TabIndex = 81;
            btnOrdenarNumerosDescendente.Text = "Ordenar Números Mayor a Menor";
            btnOrdenarNumerosDescendente.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(111, 331);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 80;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
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
            Controls.Add(btnOrdenarNumerosDescendente);
            Controls.Add(btnSalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
