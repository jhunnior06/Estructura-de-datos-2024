namespace Laboratorio_8._16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnAgregarPalabras.Click += BtnAgregarPalabras_Click;
            btnPalabrasEnOrdenadosAscendente.Click += BtnPalabrasEnOrdenadosAscendente_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private void BtnAgregarPalabras_Click(object sender, EventArgs e)
        {
            string palabra = txtAgregarPalabras.Text.Trim();
            if (!string.IsNullOrEmpty(palabra))
            {
                txtLista1.AppendText(palabra + Environment.NewLine);
                txtAgregarPalabras.Clear();
            }
        }

        private void BtnPalabrasEnOrdenadosAscendente_Click(object sender, EventArgs e)
        {
            List<string> palabras = txtLista1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> palindromosOrdenados = ObtenerPalindromosOrdenados(palabras);
            txtLista2.Text = string.Join(Environment.NewLine, palindromosOrdenados);
        }

        private bool EsPalindromo(string palabra)
        {
            int i = 0;
            int j = palabra.Length - 1;
            while (i < j)
            {
                if (char.ToLower(palabra[i]) != char.ToLower(palabra[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }

        private List<string> ObtenerPalindromosOrdenados(List<string> palabras)
        {
            return palabras
                .Where(palabra => EsPalindromo(palabra))
                .OrderBy(palabra => palabra.Length)
                .ThenBy(palabra => palabra)
                .ToList();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


