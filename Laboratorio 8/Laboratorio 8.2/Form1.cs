namespace Laboratorio_8._2
{
    public partial class Form1 : Form
    {
        private List<string> palabras = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregarPalabras_Click(object sender, EventArgs e)
        {
            palabras.Add(txtLetra.Text);
            txtLista1.AppendText(txtLetra.Text + Environment.NewLine);
            txtLetra.Clear();
            txtLetra.Focus();
        }

        private void btnFiltrarPalabrasPorLetra_Click(object sender, EventArgs e)
        {
            char letra = textFiltrarPalabrasPorLetra.Text[0];
            var filtradas = palabras.FindAll(p => p.StartsWith(letra.ToString(), StringComparison.OrdinalIgnoreCase));

            txtLista2.Clear();
            foreach (var palabra in filtradas)
            {
                txtLista2.AppendText(palabra + Environment.NewLine);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

