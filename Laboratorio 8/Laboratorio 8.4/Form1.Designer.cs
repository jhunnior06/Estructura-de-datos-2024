namespace Laboratorio_8._4
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
            txtLista2 = new TextBox();
            btnInterseccionDeConjunto = new Button();
            txtLista1 = new TextBox();
            btnAgregarNumerosDelConjunoto1 = new Button();
            txtAgregarNumerosDelConjunoto1 = new TextBox();
            btnsalir = new Button();
            btnAgregarNumerosDelConjunto2 = new Button();
            txtAgregarNumerosDelConjunto2 = new TextBox();
            txtLista3 = new TextBox();
            SuspendLayout();
            // 
            // txtLista2
            // 
            txtLista2.Location = new Point(387, 154);
            txtLista2.Multiline = true;
            txtLista2.Name = "txtLista2";
            txtLista2.Size = new Size(287, 153);
            txtLista2.TabIndex = 32;
            // 
            // btnInterseccionDeConjunto
            // 
            btnInterseccionDeConjunto.Location = new Point(95, 352);
            btnInterseccionDeConjunto.Name = "btnInterseccionDeConjunto";
            btnInterseccionDeConjunto.Size = new Size(259, 29);
            btnInterseccionDeConjunto.TabIndex = 31;
            btnInterseccionDeConjunto.Text = "Interseccion de Conjunto 1 y 2";
            btnInterseccionDeConjunto.UseVisualStyleBackColor = true;
            btnInterseccionDeConjunto.Click += btnInterseccionDeConjunto_Click;
            // 
            // txtLista1
            // 
            txtLista1.Location = new Point(387, 3);
            txtLista1.Multiline = true;
            txtLista1.Name = "txtLista1";
            txtLista1.Size = new Size(287, 136);
            txtLista1.TabIndex = 30;
            // 
            // btnAgregarNumerosDelConjunoto1
            // 
            btnAgregarNumerosDelConjunoto1.Location = new Point(95, 45);
            btnAgregarNumerosDelConjunoto1.Name = "btnAgregarNumerosDelConjunoto1";
            btnAgregarNumerosDelConjunoto1.Size = new Size(259, 29);
            btnAgregarNumerosDelConjunoto1.TabIndex = 29;
            btnAgregarNumerosDelConjunoto1.Text = "Agregar Numeros Del conjunto 1";
            btnAgregarNumerosDelConjunoto1.UseVisualStyleBackColor = true;
            btnAgregarNumerosDelConjunoto1.Click += btnAgregarNumerosDelConjunoto1_Click;
            // 
            // txtAgregarNumerosDelConjunoto1
            // 
            txtAgregarNumerosDelConjunoto1.Location = new Point(95, 12);
            txtAgregarNumerosDelConjunoto1.Name = "txtAgregarNumerosDelConjunoto1";
            txtAgregarNumerosDelConjunoto1.Size = new Size(259, 27);
            txtAgregarNumerosDelConjunoto1.TabIndex = 28;
            // 
            // btnsalir
            // 
            btnsalir.Location = new Point(95, 409);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(94, 29);
            btnsalir.TabIndex = 27;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = true;
            btnsalir.Click += btnsalir_Click;
            // 
            // btnAgregarNumerosDelConjunto2
            // 
            btnAgregarNumerosDelConjunto2.Location = new Point(95, 204);
            btnAgregarNumerosDelConjunto2.Name = "btnAgregarNumerosDelConjunto2";
            btnAgregarNumerosDelConjunto2.Size = new Size(259, 29);
            btnAgregarNumerosDelConjunto2.TabIndex = 35;
            btnAgregarNumerosDelConjunto2.Text = "Agregar Numeros Del conjunto 2";
            btnAgregarNumerosDelConjunto2.UseVisualStyleBackColor = true;
            btnAgregarNumerosDelConjunto2.Click += btnAgregarNumerosDelConjunto2_Click;
            // 
            // txtAgregarNumerosDelConjunto2
            // 
            txtAgregarNumerosDelConjunto2.Location = new Point(95, 171);
            txtAgregarNumerosDelConjunto2.Name = "txtAgregarNumerosDelConjunto2";
            txtAgregarNumerosDelConjunto2.Size = new Size(259, 27);
            txtAgregarNumerosDelConjunto2.TabIndex = 34;
            // 
            // txtLista3
            // 
            txtLista3.Location = new Point(387, 333);
            txtLista3.Multiline = true;
            txtLista3.Name = "txtLista3";
            txtLista3.Size = new Size(287, 119);
            txtLista3.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLista3);
            Controls.Add(btnAgregarNumerosDelConjunto2);
            Controls.Add(txtAgregarNumerosDelConjunto2);
            Controls.Add(txtLista2);
            Controls.Add(btnInterseccionDeConjunto);
            Controls.Add(txtLista1);
            Controls.Add(btnAgregarNumerosDelConjunoto1);
            Controls.Add(txtAgregarNumerosDelConjunoto1);
            Controls.Add(btnsalir);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtLista2;
        private System.Windows.Forms.Button btnInterseccionDeConjunto;
        private System.Windows.Forms.TextBox txtLista1;
        private System.Windows.Forms.Button btnAgregarNumerosDelConjunoto1;
        private System.Windows.Forms.TextBox txtAgregarNumerosDelConjunoto1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnAgregarNumerosDelConjunto2;
        private System.Windows.Forms.TextBox txtAgregarNumerosDelConjunto2;
        private TextBox txtLista3;
    }
}
