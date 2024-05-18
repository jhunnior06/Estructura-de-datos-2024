namespace Laboratorio_8._18
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

        private void BtnPalabrasConLetraDeterminadaEnOrdenadosDescendente_Click(object sender, EventArgs e)
        {
            string letraDeterminada = txtLetraDeterminada.Text.Trim();
            if (letraDeterminada.All(char.IsLetter))
            {
                string palabras = txtLista1.Text.Trim();
                string[] palabrasArray = palabras.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                List<string> palabrasFiltradas = new List<string>();
                foreach (var palabra in palabrasArray)
                {
                    if (palabra.IndexOf(letraDeterminada, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        palabrasFiltradas.Add(palabra);
                    }
                }

                palabrasFiltradas = palabrasFiltradas.OrderByDescending(p => p.Length).ThenByDescending(p => p).ToList();

                txtLista2.Clear();
                foreach (var palabra in palabrasFiltradas)
                {
                    txtLista2.AppendText(palabra + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese solo letras en el cuadro de letra determinada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}