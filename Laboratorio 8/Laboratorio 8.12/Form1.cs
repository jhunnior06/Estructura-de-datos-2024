namespace Laboratorio_8._12
{
    public partial class Form1 : Form
    {
        private HashSet<int> conjuntoNumeros = new HashSet<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            btnOrdenarNumerosDescendente.Click += btnOrdenarNumerosDescendente_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarNumero.Text.Trim(), out int nuevoNumero))
            {
                if (!conjuntoNumeros.Contains(nuevoNumero))
                {
                    conjuntoNumeros.Add(nuevoNumero);
                    ActualizarTextBox(txtLista1, conjuntoNumeros);
                    txtAgregarNumero.Clear();
                }
                else
                {
                    MessageBox.Show("El número ya ha sido agregado.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnOrdenarNumerosDescendente_Click(object sender, EventArgs e)
        {
            var numerosOrdenadosDesc = OrdenarNumerosDescendente(conjuntoNumeros);
            ActualizarTextBox(txtLista2, numerosOrdenadosDesc);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IEnumerable<int> OrdenarNumerosDescendente(HashSet<int> numeros)
        {
            return numeros.OrderByDescending(n => n);
        }

        private void ActualizarTextBox(TextBox textBox, IEnumerable<int> items)
        {
            textBox.Clear();
            foreach (int item in items)
            {
                textBox.AppendText(item + Environment.NewLine);
            }
        }
    }
}

