namespace Laboratorio_7._2
{
    public partial class Form1 : Form
    {
        private Jefe jefe;
        public Form1()
        {
            InitializeComponent();
            cmbArea.SelectedIndex = 0;
            cmbCargo.SelectedIndex = 0;
            btnCrearObjeto.Click += btnCrearObjeto_Click;
            btnMostrar.Click += btnMostrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
            textDni.KeyPress += textDni_KeyPress;
            textNombres.KeyPress += textNombres_KeyPress;

        }
        private void btnCrearObjeto_Click(object sender, EventArgs e)
        {
            string nombres = textNombres.Text;
            string dni = textDni.Text;
            string cargo = cmbCargo.SelectedItem?.ToString().Trim();
            string area = cmbArea.SelectedItem?.ToString().Trim();
            int aniosAntiguedad;

            if (!int.TryParse(textBox1.Text, out aniosAntiguedad))
            {
                MessageBox.Show("El valor de 'Años de Antigüedad' no es válido.");
                return;
            }
            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(cargo) || string.IsNullOrEmpty(area))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            jefe = new Jefe(nombres, dni, cargo, area, aniosAntiguedad);
            MessageBox.Show("Objeto Jefe creado correctamente.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (jefe != null)
            {
                txtResultado.Text = jefe.ObtenerInformacion();
            }
            else
            {
                MessageBox.Show("No se ha creado un objeto Jefe.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombres.Clear();
            textDni.Clear();
            cmbCargo.SelectedIndex = -1;
            cmbArea.SelectedIndex = -1;
            textBox1.Clear();
            txtResultado.Clear();
            jefe = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textDni_TextChanged(object sender, EventArgs e)
        {

        }
        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (textDni.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

    }
}
