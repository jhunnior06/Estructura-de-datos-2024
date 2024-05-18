
namespace Laboratorio_8._4
{
    public partial class Form1 : Form
    {
        private HashSet<int> conjunto1 = new HashSet<int>();
        private HashSet<int> conjunto2 = new HashSet<int>();

        public Form1()
        {
            InitializeComponent();
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
        private void btnInterseccionDeConjunto_Click(object sender, EventArgs e)
        {
            HashSet<int> interseccion = InterseccionDeConjuntos(conjunto1, conjunto2);
            ActualizarTextBox(txtLista3, interseccion);
        }

        private HashSet<int> InterseccionDeConjuntos(HashSet<int> set1, HashSet<int> set2)
        {
            HashSet<int> interseccion = new HashSet<int>(set1);
            interseccion.IntersectWith(set2);
            return interseccion;
        }

        private void ActualizarTextBox(TextBox textBox, HashSet<int> conjunto)
        {
            textBox.Clear();
            foreach (var numero in conjunto)
            {
                textBox.AppendText(numero + Environment.NewLine);
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


