
namespace Laboratorio_8._9
{
    public partial class Form1 : Form
    {
        private HashSet<string> conjuntoPalabras = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;
            btnEncontrarPalabrasPorLongitud.Click += btnEncontrarPalabrasPorLongitud_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            string nuevaPalabra = txtAgregarPalabra.Text.Trim();
            if (EsPalabraValida(nuevaPalabra))
            {
                if (!conjuntoPalabras.Contains(nuevaPalabra))
                {
                    conjuntoPalabras.Add(nuevaPalabra);
                    ActualizarTextBox(txtLista1, conjuntoPalabras);
                    txtAgregarPalabra.Clear();
                }
                else
                {
                    MessageBox.Show("La palabra ya ha sido agregada.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una palabra válida (solo letras del alfabeto).");
            }
        }

        private bool EsPalabraValida(string palabra)
        {
            return !string.IsNullOrEmpty(palabra) && palabra.All(char.IsLetter);
        }

        private void btnEncontrarPalabrasPorLongitud_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLongitud.Text.Trim(), out int longitud))
            {
                HashSet<string> palabrasPorLongitud = EncontrarPalabrasPorLongitud(conjuntoPalabras, longitud);
                ActualizarTextBox(txtLista2, palabrasPorLongitud);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una longitud válida (un número entero).");
            }
        }

        private HashSet<string> EncontrarPalabrasPorLongitud(HashSet<string> palabras, int longitud)
        {
            return new HashSet<string>(palabras.Where(p => p.Length == longitud));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ActualizarTextBox(TextBox textBox, IEnumerable<string> items)
        {
            textBox.Clear();
            foreach (string item in items)
            {
                textBox.AppendText(item + Environment.NewLine);
            }
        }
    }
}

