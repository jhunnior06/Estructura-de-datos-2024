using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Laboratorio_8_20 // Cambio de nombre del namespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAgregarPalabras_Click(object sender, EventArgs e)
        {
            string palabras = txtAgregarPalabras.Text.Trim();
            if (!string.IsNullOrWhiteSpace(palabras))
            {
                txtLista1.AppendText(palabras + Environment.NewLine);
                txtAgregarPalabras.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese palabras en el cuadro de texto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPalabrasPalindromosConLungetudDeterminadaEnOrdenadosAscendente_Click(object sender, EventArgs e)
        {
            int longitud;
            if (int.TryParse(txtLungetudesDeterminadas.Text, out longitud) && longitud > 0)
            {
                string palabras = txtLista1.Text.Trim();
                string[] palabrasArray = palabras.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                List<string> palabrasFiltradas = new List<string>();
                foreach (var palabra in palabrasArray)
                {
                    if (EsPalindromo(palabra) && palabra.Length == longitud)
                    {
                        palabrasFiltradas.Add(palabra);
                    }
                }

                palabrasFiltradas = palabrasFiltradas.OrderBy(p => p).ToList();

                txtLista2.Clear();
                foreach (var palabra in palabrasFiltradas)
                {
                    txtLista2.AppendText(palabra + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una longitud válida en el cuadro de longitud determinada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsPalindromo(string palabra)
        {
            palabra = palabra.ToLower(); // Convertimos todas las letras a minúsculas
            int i = 0;
            int j = palabra.Length - 1;

            while (i < j)
            {
                if (palabra[i] != palabra[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        private void txtAgregarPalabras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLungetudesDeterminadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
