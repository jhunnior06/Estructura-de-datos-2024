namespace Laboratorio_8._15
{
    public partial class Form1 : Form
    {
        List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumero.Click += btnAgregarNumero_Click;
            btnNumerosPrimosOrdenadosAscendente.Click += btnNumerosPrimosOrdenadosAscendente_Click;
            btnSalir.Click += btnSalir_Click;
        }

        private void btnAgregarNumero_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAgregarNumero.Text))
            {
                if (int.TryParse(txtAgregarNumero.Text, out int num))
                {
                    numeros.Add(num);
                    txtLista1.Text += num + Environment.NewLine;
                    txtAgregarNumero.Text = "";
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número.");
            }
        }

        private void btnNumerosPrimosOrdenadosAscendente_Click(object sender, EventArgs e)
        {
            List<int> primosOrdenados = ObtenerPrimosOrdenados(numeros);
            txtLista2.Text = string.Join(Environment.NewLine, primosOrdenados);
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero <= 3) return true;
            if (numero % 2 == 0 || numero % 3 == 0) return false;

            for (int i = 5; i * i <= numero; i += 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static List<int> ObtenerPrimosOrdenados(List<int> numeros)
        {
            return numeros.Where(n => EsPrimo(n)).OrderBy(n => n).Distinct().ToList();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

