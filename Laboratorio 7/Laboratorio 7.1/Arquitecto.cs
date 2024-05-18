namespace Laboratorio_7._1
{
   
    public class Arquitecto
    {
        public string Codigo { get; }
        public string Nombres { get; }
        public string CondicionContrato { get; }
        public string Especialidad { get; }
        public string TipoActividad { get; }
        public string TipoAfiliacion { get; }
        public double SueldoBase { get; private set; }
        public double Bonificacion { get; private set; }
        public double Descuento { get; private set; }
        public double SueldoBruto => SueldoBase + Bonificacion;
        public double SueldoNeto => SueldoBruto - Descuento;

        public Arquitecto(string codigo, string nombres, string condicionContrato, string especialidad,
                            string tipoActividad, string tipoAfiliacion)
        {
            Codigo = codigo;
            Nombres = nombres;
            CondicionContrato = condicionContrato;
            Especialidad = especialidad;
            TipoActividad = tipoActividad;
            TipoAfiliacion = tipoAfiliacion;

            SueldoBase = CalcularSueldoBase();
            Bonificacion = CalcularBonificacion();
            Descuento = CalcularDescuento();
        }

        private double CalcularSueldoBase()
        {
            double sueldoBase = 0;

            if (CondicionContrato.Equals("ESTABLE", StringComparison.OrdinalIgnoreCase))
            {
                if (TipoActividad.Equals("SUPERVISION DE OBRAS", StringComparison.OrdinalIgnoreCase))
                {
                    sueldoBase = 4000;
                }
                else if (TipoActividad.Equals("SUPERVISION DE VIAS", StringComparison.OrdinalIgnoreCase))
                {
                    sueldoBase = 6000;
                }
            }
            else if (CondicionContrato.Equals("CONTRATADO", StringComparison.OrdinalIgnoreCase))
            {
                if (TipoActividad.Equals("SUPERVISION DE OBRAS", StringComparison.OrdinalIgnoreCase))
                {
                    sueldoBase = 2000;
                }
                else if (TipoActividad.Equals("SUPERVISION DE VIAS", StringComparison.OrdinalIgnoreCase))
                {
                    sueldoBase = 4500;
                }
            }

            return sueldoBase;
        }

        private double CalcularBonificacion()
        {
            double porcentajeBonificacion = 0;

            if (Especialidad.Equals("Estructuras", StringComparison.OrdinalIgnoreCase))
            {
                porcentajeBonificacion = 0.16;
            }
            else if (Especialidad.Equals("Recursos Hídricos", StringComparison.OrdinalIgnoreCase))
            {
                porcentajeBonificacion = 0.18;
            }

            return SueldoBase * porcentajeBonificacion;
        }

        private double CalcularDescuento()
        {
            double porcentajeDescuento = 0;
            if (TipoAfiliacion.Equals("AFP", StringComparison.OrdinalIgnoreCase))
            {
                porcentajeDescuento = 0.15;
            }
            else if (TipoAfiliacion.Equals("SNP", StringComparison.OrdinalIgnoreCase))
            {
                porcentajeDescuento = 0.08;
            }
            return SueldoBase * porcentajeDescuento;
        }
    }
}

