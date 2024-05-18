namespace Laboratorio_8._13
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            btnBuscarDuplicados.Click += btnBuscarDuplicados_Click;
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

        private void btnBuscarDuplicados_Click(object sender, EventArgs e)
        {
            Dictionary<int, int> conteo = ContarNumeros(numeros);
            HashSet<int> duplicados = EncontrarDuplicados(conteo);
            ActualizarTextBox(txtLista2, duplicados);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Dictionary<int, int> ContarNumeros(List<int> numeros)
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

            return conteo;
        }

        private HashSet<int> EncontrarDuplicados(Dictionary<int, int> conteo)
        {
            var duplicados = new HashSet<int>();

            foreach (var kvp in conteo)
            {
                if (kvp.Value > 1)
                {
                    duplicados.Add(kvp.Key);
                }
            }

            return duplicados;
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

