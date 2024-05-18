using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratorio8
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // C�digo de inicializaci�n o carga inicial de la forma
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            // Manejo del evento clic en el bot�n para agregar n�meros
            string numeroTexto = txtNumero.Text.Trim();

            if (!string.IsNullOrEmpty(numeroTexto))
            {
                // Intentar convertir el texto a n�mero
                if (int.TryParse(numeroTexto, out int numero))
                {
                    // Agregar el n�mero a la lista y actualizar la interfaz
                    txtLista1.AppendText(numero.ToString() + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un n�mero v�lido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un n�mero.");
            }
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            // Manejo del evento clic en el bot�n para buscar n�meros primos
            txtLista2.Clear();

            string[] numerosTexto = txtLista1.Text.Trim().Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string numeroTexto in numerosTexto)
            {
                if (int.TryParse(numeroTexto, out int numero))
                {
                    if (EsPrimo(numero))
                    {
                        txtLista2.AppendText(numero.ToString() + Environment.NewLine);
                    }
                }
            }
        }

        private bool EsPrimo(int numero)
        {
            // M�todo para verificar si un n�mero es primo
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
