namespace Laboratorio_8._5
{
    public partial class Form1 : Form
    {
        private HashSet<int> conjunto1 = new HashSet<int>();
        private HashSet<int> conjunto2 = new HashSet<int>();
        public Form1()
        {
            InitializeComponent();
            btnAgregarNumerosDelConjunoto1.Click += btnAgregarNumerosDelConjunoto1_Click;
            btnAgregarNumerosDelConjunto2.Click += btnAgregarNumerosDelConjunto2_Click;
            btnDiferenciaDeConjunto.Click += btnDiferenciaDeConjunto_Click;
            btnsalir.Click += btnsalir_Click;
        }

        private void btnAgregarNumerosDelConjunoto1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarNumerosDelConjunoto1.Text, out int numero))
            {
                conjunto1.Add(numero);
                ActualizarTextBox(txtLista1, conjunto1);
                txtAgregarNumerosDelConjunoto1.Clear();
                txtAgregarNumerosDelConjunoto1.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnAgregarNumerosDelConjunto2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtAgregarNumerosDelConjunto2.Text, out int numero))
            {
                conjunto2.Add(numero);
                ActualizarTextBox(txtLista2, conjunto2);
                txtAgregarNumerosDelConjunto2.Clear();
                txtAgregarNumerosDelConjunto2.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnDiferenciaDeConjunto_Click(object sender, EventArgs e)
        {
            HashSet<int> conjunto1 = ObtenerConjunto(txtLista1.Text);
            HashSet<int> conjunto2 = ObtenerConjunto(txtLista2.Text);
            HashSet<int> diferencia = new HashSet<int>(conjunto1);
            diferencia.ExceptWith(conjunto2);
            txtLista3.Text = string.Join(Environment.NewLine, diferencia);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private HashSet<int> ObtenerConjunto(string texto)
        {
            HashSet<int> conjunto = new HashSet<int>();
            foreach (string numeroTexto in texto.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(numeroTexto, out int numero))
                {
                    conjunto.Add(numero);
                }
            }
            return conjunto;
        }
        private void AgregarNumerosAlTextBox(string numeros, TextBox textBox)
        {
            textBox.AppendText(numeros + Environment.NewLine);
        }

        private void ActualizarTextBox(TextBox textBox, HashSet<int> conjunto)
        {
            textBox.Clear();
            foreach (var numero in conjunto)
            {
                textBox.AppendText(numero + Environment.NewLine);
            }
        }

    }
}

