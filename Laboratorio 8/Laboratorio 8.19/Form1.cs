namespace Laboratorio_8._19
{
    public partial class Form1 : Form
    {
        private List<int> numeros = new List<int>();

        public Form1()
        {
            InitializeComponent();
            btnAgregarNumeros.Click += BtnAgregarNumeros_Click;
            btnPalabrasConLongetudDeterminadaEnOrdenadosAscendente.Click += BtnNumerosOrdenadosNoDuplicados_Click;
        }

        private void BtnAgregarNumeros_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarNumeros.Text, out int numero))
            {
                numeros.Add(numero);
                ActualizarTxtLista1();
                txtAgregarNumeros.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTxtLista1()
        {
            txtLista1.Clear();
            foreach (var num in numeros)
            {
                txtLista1.AppendText(num + Environment.NewLine);
            }
        }

        private void BtnNumerosOrdenadosNoDuplicados_Click(object sender, EventArgs e)
        {
            List<int> numerosOrdenadosUnicos = ObtenerNumerosUnicos(numeros);
            numerosOrdenadosUnicos.Sort();

            txtLista2.Clear();

            foreach (var num in numerosOrdenadosUnicos)
            {
                txtLista2.AppendText(num + Environment.NewLine);
            }
        }

        private List<int> ObtenerNumerosUnicos(List<int> numeros)
        {
            var frecuencia = numeros.GroupBy(n => n)
                                    .Where(g => g.Count() == 1)
                                    .Select(g => g.Key)
                                    .ToList();
            return frecuencia;
        }
    }
}




