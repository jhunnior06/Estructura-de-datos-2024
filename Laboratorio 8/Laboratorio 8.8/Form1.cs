namespace Laboratorio_8._8
{
    public partial class Form1 : Form
    {
        private HashSet<string> conjuntoPalabras = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;
            btnEncontrarPalindromos.Click += btnEncontrarPalindromos_Click;
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

        private void btnEncontrarPalindromos_Click(object sender, EventArgs e)
        {
            HashSet<string> palindromos = EncontrarPalindromos(conjuntoPalabras);
            ActualizarTextBox(txtLista2, palindromos);
        }

        private HashSet<string> EncontrarPalindromos(HashSet<string> palabras)
        {
            var palindromos = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (EsPalindromo(palabra))
                {
                    palindromos.Add(palabra);
                }
            }

            return palindromos;
        }

        private bool EsPalindromo(string palabra)
        {
            string palabraInvertida = new string(palabra.Reverse().ToArray());
            return palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);
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
