using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_8_20 // Corrección del nombre del namespace
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLungetudesDeterminadas;
        private TextBox txtLungetudesDeterminadas;
        private TextBox txtAgregarPalabras;
        private TextBox txtLista1;
        private TextBox txtLista2;
        private Button btnAgregarPalabras;
        private Button btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente;
        private Button btnSalir;

        //public Form1()
        //{
        //    InitializeComponent();
        //}

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLungetudesDeterminadas = new System.Windows.Forms.Label();
            this.txtLungetudesDeterminadas = new System.Windows.Forms.TextBox();
            this.txtAgregarPalabras = new System.Windows.Forms.TextBox();
            this.txtLista1 = new System.Windows.Forms.TextBox();
            this.txtLista2 = new System.Windows.Forms.TextBox();
            this.btnAgregarPalabras = new System.Windows.Forms.Button();
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLungetudesDeterminadas
            // 
            this.lblLungetudesDeterminadas.AutoSize = true;
            this.lblLungetudesDeterminadas.Location = new System.Drawing.Point(48, 107);
            this.lblLungetudesDeterminadas.Name = "lblLungetudesDeterminadas";
            this.lblLungetudesDeterminadas.Size = new System.Drawing.Size(250, 20);
            this.lblLungetudesDeterminadas.TabIndex = 133;
            this.lblLungetudesDeterminadas.Text = "Longitud de la Palabras Palindromos";
            // 
            // txtLungetudesDeterminadas
            // 
            this.txtLungetudesDeterminadas.Location = new System.Drawing.Point(48, 130);
            this.txtLungetudesDeterminadas.Name = "txtLungetudesDeterminadas";
            this.txtLungetudesDeterminadas.Size = new System.Drawing.Size(259, 27);
            this.txtLungetudesDeterminadas.TabIndex = 132;
            // 
            // txtAgregarPalabras
            // 
            this.txtAgregarPalabras.Location = new System.Drawing.Point(48, 15);
            this.txtAgregarPalabras.Name = "txtAgregarPalabras";
            this.txtAgregarPalabras.Size = new System.Drawing.Size(259, 27);
            this.txtAgregarPalabras.TabIndex = 129;
            // 
            // txtLista1
            // 
            this.txtLista1.Location = new System.Drawing.Point(477, 12);
            this.txtLista1.Multiline = true;
            this.txtLista1.Name = "txtLista1";
            this.txtLista1.ReadOnly = true;
            this.txtLista1.Size = new System.Drawing.Size(287, 217);
            this.txtLista1.TabIndex = 128;
            // 
            // txtLista2
            // 
            this.txtLista2.Location = new System.Drawing.Point(477, 255);
            this.txtLista2.Multiline = true;
            this.txtLista2.Name = "txtLista2";
            this.txtLista2.ReadOnly = true;
            this.txtLista2.Size = new System.Drawing.Size(287, 183);
            this.txtLista2.TabIndex = 131;
            // 
            // btnAgregarPalabras
            // 
            this.btnAgregarPalabras.Location = new System.Drawing.Point(48, 48);
            this.btnAgregarPalabras.Name = "btnAgregarPalabras";
            this.btnAgregarPalabras.Size = new System.Drawing.Size(259, 29);
            this.btnAgregarPalabras.TabIndex = 130;
            this.btnAgregarPalabras.Text = "Agregar Palabras";
            this.btnAgregarPalabras.UseVisualStyleBackColor = true;
            this.btnAgregarPalabras.Click += new System.EventHandler(this.BtnAgregarPalabras_Click); // Suscripción al evento Click
            // 
            // btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente
            // 
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.Location = new System.Drawing.Point(37, 290);
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.Name = "btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente";
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.Size = new System.Drawing.Size(310, 53);
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.TabIndex = 127;
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.Text = "Palabras Palindromos Con Lugitud Determinada Ordenados de Menor a Mayor";
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.UseVisualStyleBackColor = true;
            this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente.Click += new System.EventHandler(this.BtnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente_Click); // Suscripción al evento Click
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(48, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 29);
            this.btnSalir.TabIndex = 126;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click); // Suscripción al evento Click
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLungetudesDeterminadas);
            this.Controls.Add(this.txtLungetudesDeterminadas);
            this.Controls.Add(this.txtAgregarPalabras);
            this.Controls.Add(this.txtLista1);
            this.Controls.Add(this.txtLista2);
            this.Controls.Add(this.btnAgregarPalabras);
            this.Controls.Add(this.btnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente);
            this.Controls.Add(this.btnSalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

