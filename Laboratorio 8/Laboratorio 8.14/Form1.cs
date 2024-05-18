namespace Laboratorio_8._14
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            btnBuscarNoDuplicados.Click += btnBuscarNoDuplicados_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            string input = txtAgregarNumero.Text.Trim();
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int numero))
            {
                numeros.Add(numero);
                ActualizarTextBox(txtLista1, numeros);
                txtAgregarNumero.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnBuscarNoDuplicados_Click(object sender, EventArgs e)
        {
            HashSet<int> noDuplicados = EncontrarNoDuplicados(numeros);
            ActualizarTextBox(txtLista2, noDuplicados);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private HashSet<int> EncontrarNoDuplicados(List<int> numeros)
        {
            var conteo = new Dictionary<int, int>();

            foreach (int numero in numeros)
            {
                if (conteo.ContainsKey(numero))
                {
                    conteo[numero]++;
                }
                else
                {
                    conteo[numero] = 1;
                }
            }

            var noDuplicados = new HashSet<int>();

            foreach (var kvp in conteo)
            {
                if (kvp.Value == 1)
                {
                    noDuplicados.Add(kvp.Key);
                }
            }

            return noDuplicados;
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

