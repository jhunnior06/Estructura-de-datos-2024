namespace Laboratorio_8._6
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
                if (!conjunto1.Contains(numero))
                {
                    conjunto1.Add(numero);
                    ActualizarTextBox(txtLista1, conjunto1);
                }
                else
                {
                    MessageBox.Show("El número ya está en el conjunto 1.");
                }
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
                if (!conjunto2.Contains(numero))
                {
                    conjunto2.Add(numero);
                    ActualizarTextBox(txtLista2, conjunto2);
                }
                else
                {
                    MessageBox.Show("El número ya está en el conjunto 2.");
                }
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
            HashSet<int> diferencia = CalcularDiferenciaDeConjuntos(conjunto1, conjunto2);
            ActualizarTextBox(txtLista3, diferencia);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private HashSet<int> CalcularDiferenciaDeConjuntos(HashSet<int> conjunto1, HashSet<int> conjunto2)
        {
            HashSet<int> diferencia = new HashSet<int>(conjunto2);
            diferencia.ExceptWith(conjunto1);
            return diferencia;
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

