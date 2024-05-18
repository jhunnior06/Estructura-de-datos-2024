namespace Laboratorio_8._11
{
    public partial class Form1 : Form
    {
        private HashSet<int> conjuntoNumeros = new HashSet<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            btnOrdenarNumeros.Click += btnOrdenarNumeros_Click;
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

        private void btnOrdenarNumeros_Click(object sender, EventArgs e)
        {
            var numerosOrdenados = OrdenarNumeros(conjuntoNumeros);
            ActualizarTextBox(txtLista2, numerosOrdenados);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IEnumerable<int> OrdenarNumeros(HashSet<int> numeros)
        {
            return numeros.OrderBy(n => n);
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

