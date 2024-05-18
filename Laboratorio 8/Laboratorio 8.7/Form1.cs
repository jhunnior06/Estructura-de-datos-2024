namespace Laboratorio_8._7
{
    public partial class Form1 : Form
    {
        private HashSet<string> conjuntoPalabras = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarPalabra.Click += btnAgregarPalabra_Click;
            btnEncontrarAnagramas.Click += btnEncontrarAnagramas_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            string nuevaPalabra = txtAgregarPalabra.Text.Trim();

            if (!string.IsNullOrEmpty(nuevaPalabra) && nuevaPalabra.Any(c => !char.IsLetter(c)))
            {
                MessageBox.Show("Por favor, ingrese una palabra válida.");
            }
            else
            {
                conjuntoPalabras.Add(nuevaPalabra);
                ActualizarTextBox(txtLista1, conjuntoPalabras);
                txtAgregarPalabra.Clear();
            }
        }

        private void btnEncontrarAnagramas_Click(object sender, EventArgs e)
        {
            HashSet<string> anagramas = EncontrarAnagramas(conjuntoPalabras);
            ActualizarTextBox(txtLista2, anagramas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private HashSet<string> EncontrarAnagramas(HashSet<string> palabras)
        {
            var anagramas = new HashSet<string>();

            var diccionarioAnagramas = new Dictionary<string, HashSet<string>>();

            foreach (string palabra in palabras)
            {
                string palabraOrdenada = string.Concat(palabra.ToLower().OrderBy(c => c));

                if (diccionarioAnagramas.ContainsKey(palabraOrdenada))
                {
                    diccionarioAnagramas[palabraOrdenada].Add(palabra);
                }
                else
                {
                    diccionarioAnagramas[palabraOrdenada] = new HashSet<string> { palabra };
                }
            }

            foreach (var anagrama in diccionarioAnagramas)
            {
                if (anagrama.Value.Count >= 2)
                {
                    anagramas.UnionWith(anagrama.Value);
                }
            }

            return anagramas;
        }

        private bool SonAnagramas(string palabra1, string palabra2)
        {
            palabra1 = palabra1.ToLower();
            palabra2 = palabra2.ToLower();

            char[] charsPalabra1 = palabra1.ToCharArray();
            char[] charsPalabra2 = palabra2.ToCharArray();
            Array.Sort(charsPalabra1);
            Array.Sort(charsPalabra2);

            string ordenada1 = new string(charsPalabra1);
            string ordenada2 = new string(charsPalabra2);

            return ordenada1 == ordenada2;
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


