namespace Laboratorio_8._10
{
    public partial class Form1 : Form
    {
        private HashSet<string> conjuntoPalabras = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;
            btnEncontrarPalabrasPorLetra.Click += btnEncontrarPalabrasPorLetra_Click;
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

        private void btnEncontrarPalabrasPorLetra_Click(object sender, EventArgs e)
        {
            string letra = txtEncontrarPalabrasPorLetra.Text.Trim();
            if (EsLetraValida(letra))
            {
                HashSet<string> palabrasPorLetra = EncontrarPalabrasPorLetra(conjuntoPalabras, letra[0]);
                ActualizarTextBox(txtLista2, palabrasPorLetra);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una letra válida.");
            }
        }

        private bool EsLetraValida(string letra)
        {
            return letra.Length == 1 && char.IsLetter(letra[0]);
        }

        private HashSet<string> EncontrarPalabrasPorLetra(HashSet<string> palabras, char letra)
        {
            return new HashSet<string>(palabras.Where(p => p.Contains(letra)));
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

