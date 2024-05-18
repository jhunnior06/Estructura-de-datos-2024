namespace Laboratorio8._20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnAgregarPalabras.Click += BtnAgregarPalabras_Click;
            btnPalabrasPalindormosConLungitudDeterminadaEnOrdenadosAscendente.Click += BtnPalabrasPalindromosConLungitudDeterminadaEnOrdenadosAscendente_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private void BtnAgregarPalabras_Click(object sender, EventArgs e)
        {
            string palabras = txtAgregarPalabras.Text.Trim();
            if (palabras.All(char.IsLetter))
            {
                string[] palabrasArray = palabras.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var palabra in palabrasArray)
                {
                    if (!string.IsNullOrWhiteSpace(palabra))
                    {
                        txtLista1.AppendText(palabra + Environment.NewLine);
                        txtAgregarPalabras.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo letras en el cuadro de palabras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnPalabrasPalindromosConLungitudDeterminadaEnOrdenadosAscendente_Click(object sender, EventArgs e)
        {
            string[] longitudes = txtLetraDeterminada.Text.Split(',');
            List<int> longitudesList = new List<int>();

            foreach (string longitudStr in longitudes)
            {
                if (int.TryParse(longitudStr, out int longitud) && longitud > 0)
                {
                    longitudesList.Add(longitud);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese longitudes válidas separadas por comas en el cuadro de longitud determinada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string palabras = txtLista1.Text.Trim();
            string[] palabrasArray = palabras.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palabrasFiltradas = new List<string>();
            foreach (var palabra in palabrasArray)
            {
                foreach (int longitud in longitudesList)
                {
                    if (EsPalindromo(palabra) && palabra.Length == longitud)
                    {
                        palabrasFiltradas.Add(palabra);
                        break;
                    }
                }
            }
            palabrasFiltradas = palabrasFiltradas.OrderBy(p => p.Length).ToList();

            txtLista2.Clear();
            foreach (var palabra in palabrasFiltradas)
            {
                txtLista2.AppendText(palabra + Environment.NewLine);
            }
        }

        private bool EsPalindromo(string palabra)
        {
            palabra = palabra.ToLower();
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLetraDeterminada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
