namespace Laboratorio_7._1
{
    public partial class Form1 : Form
    {
        private Arquitecto arquitecto;

        public Form1()
        {
            InitializeComponent();
            cmbCondicionContrato.SelectedIndex = 0;
            cmbEspecialidad.SelectedIndex = 0;
            cmbTipoActividad.SelectedIndex = 0;
            cmbTipoAfiliacion.SelectedIndex = 0;
            btnCrearObjeto.Click += btnCrearObjeto_Click;
            btnMostrar.Click += btnMostrar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnSalir.Click += btnSalir_Click;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            txtNombres.KeyPress += txtNombres_KeyPress;
        }

        private void btnCrearObjeto_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;
            string nombres = txtNombres.Text;
            string condicionContrato = cmbCondicionContrato.SelectedItem?.ToString();
            string especialidad = cmbEspecialidad.SelectedItem?.ToString();
            string tipoActividad = cmbTipoActividad.SelectedItem?.ToString();
            string tipoAfiliacion = cmbTipoAfiliacion.SelectedItem?.ToString();

            if (!int.TryParse(codigo, out _) || codigo.Length != 8)
            {
                MessageBox.Show("El código debe ser un número de 8 dígitos.");
                return;
            }

            if (string.IsNullOrEmpty(nombres) || string.IsNullOrEmpty(condicionContrato) ||
                string.IsNullOrEmpty(especialidad) || string.IsNullOrEmpty(tipoActividad) || string.IsNullOrEmpty(tipoAfiliacion))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            arquitecto = new Arquitecto(codigo, nombres, condicionContrato, especialidad, tipoActividad, tipoAfiliacion);
            MessageBox.Show("Objeto arquitecto creado correctamente.");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (arquitecto != null)
            {
                txtResultado.Text = $"Código: {arquitecto.Codigo}\r\n" +
                                    $"Nombres: {arquitecto.Nombres}\r\n" +
                                    $"Condición de contrato: {arquitecto.CondicionContrato}\r\n" +
                                    $"Especialidad: {arquitecto.Especialidad}\r\n" +
                                    $"Tipo de actividad: {arquitecto.TipoActividad}\r\n" +
                                    $"Tipo de afiliación: {arquitecto.TipoAfiliacion}\r\n" +
                                    $"Sueldo Base: {arquitecto.SueldoBase}\r\n" +
                                    $"Bonificación: {arquitecto.Bonificacion}\r\n" +
                                    $"Descuento: {arquitecto.Descuento}\r\n" +
                                    $"Sueldo Bruto: {arquitecto.SueldoBruto}\r\n" +
                                    $"Sueldo Neto: {arquitecto.SueldoNeto}";
            }
            else
            {
                MessageBox.Show("Debe crear un objeto arquitecto primero.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombres.Clear();
            cmbCondicionContrato.SelectedIndex = -1;
            cmbEspecialidad.SelectedIndex = -1;
            cmbTipoActividad.SelectedIndex = -1;
            cmbTipoAfiliacion.SelectedIndex = -1;
            txtResultado.Clear();
            arquitecto = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (txtCodigo.Text.Length >= 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
