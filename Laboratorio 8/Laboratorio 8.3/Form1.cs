namespace Laboratorio_8._3
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumeros.Click += new EventHandler(btnAgregarNumeros_Click);
            btnFiltrarPorDivisivilidad.Click += new EventHandler(btnFiltrarPorDivisivilidad_Click);
            btnsalir.Click += new EventHandler(btnsalir_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarNumeros_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarNumero.Text, out int numero))
            {
                numeros.Add(numero);
                txtLista1.AppendText(numero.ToString() + Environment.NewLine);
                txtAgregarNumero.Clear();
                txtAgregarNumero.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnFiltrarPorDivisivilidad_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textFiltrarPorDivisivilidad.Text, out int divisor))
            {
                if (divisor == 0)
                {
                    MessageBox.Show("El divisor no puede ser cero.");
                    return;
                }

                var divisibles = FiltrarPorDivisibilidad(numeros, divisor);
                txtLista2.Clear();
                foreach (var num in divisibles)
                {
                    txtLista2.AppendText(num.ToString() + Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un divisor válido.");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static HashSet<int> FiltrarPorDivisibilidad(IEnumerable<int> numeros, int divisor)
        {
            return new HashSet<int>(numeros.Where(n => n % divisor == 0));
        }
    }
}

