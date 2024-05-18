namespace Laboratorio_8._17
{
    public partial class Form1 : Form
    {
        private HashSet<string> palabras = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarPalabras.Click += BtnAgregarPalabras_Click;
            txtLongitudPalabra.KeyPress += TxtLongitudPalabra_KeyPress;
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Click += BtnPalabrasConLongetudDeterminadaEnOrdenadosAscendente_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private void BtnAgregarPalabras_Click(object sender, EventArgs e)
        {
            string palabra = txtAgregarPalabras.Text.Trim();
            if (!string.IsNullOrWhiteSpace(palabra) && palabra.All(char.IsLetter))
            {
                palabras.Add(palabra);
                txtLista1.Text = string.Join(Environment.NewLine, palabras.OrderBy(p => p));

                txtAgregarPalabras.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese una palabra válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtLongitudPalabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ActualizarListaPalabrasConLongitud();
            }
        }

        private void BtnPalabrasConLongetudDeterminadaEnOrdenadosAscendente_Click(object sender, EventArgs e)
        {
            ActualizarListaPalabrasConLongitud();
        }

        private void ActualizarListaPalabrasConLongitud()
        {
            string[] longitudesStr = txtLongitudPalabra.Text.Split(',');
            List<int> longitudes = new List<int>();

            foreach (string longitudStr in longitudesStr)
            {
                if (int.TryParse(longitudStr.Trim(), out int longitud) && longitud >= 0)
                {
                    longitudes.Add(longitud);
                }
                else
                {
                    MessageBox.Show("Ingrese longitudes válidas (mayor o igual a 0) separadas por comas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var palabrasFiltradas = palabras
                .Where(p => longitudes.Any(l => p.Length == l))
                .OrderBy(p => p.Length)
                .ThenBy(p => p);

            txtLista2.Text = string.Join(Environment.NewLine, palabrasFiltradas);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


