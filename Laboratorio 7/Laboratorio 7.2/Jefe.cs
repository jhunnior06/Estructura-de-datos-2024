namespace Laboratorio_7._2
{
    internal class Jefe
    {
        public string Nombres { get; }
        public string DNI { get; }
        public string Cargo { get; }
        public string Area { get; }
        public int AniosAntiguedad { get; }

        public Jefe(string nombres, string dni, string cargo, string area, int aniosAntiguedad)
        {
            Nombres = nombres;
            DNI = dni;
            Cargo = cargo;
            Area = area;
            AniosAntiguedad = aniosAntiguedad;
        }

        public double CalcularSueldoBase()
        {
            double sueldoBase = 0;

            if (Cargo == "GERENTE")
            {
                if (Area == "CONTABILIDAD")
                    sueldoBase = 6000;
                else if (Area == "PLANIFICACION")
                    sueldoBase = 8000;
            }
            else if (Cargo == "SUBGERENTE")
            {
                if (Area == "CONTABILIDAD")
                    sueldoBase = 5000;
                else if (Area == "PLANIFICACION")
                    sueldoBase = 7000;
            }

            return sueldoBase;
        }
        public double CalcularBonificacion()
        {
            return 2000;
        }

        public double CalcularDescuentos()
        {
            double sueldoBase = CalcularSueldoBase();
            double descuentoAFP = 0.15 * sueldoBase;
            double descuentoSNP = 0.08 * sueldoBase;
            return descuentoAFP + descuentoSNP;
        }

        public double CalcularSueldoBruto()
        {
            return CalcularSueldoBase() + CalcularBonificacion();
        }

        public double CalcularSueldoNeto()
        {
            return CalcularSueldoBruto() - CalcularDescuentos();
        }
        public string ObtenerInformacion()
        {
            double sueldoBase = CalcularSueldoBase();
            double sueldoBruto = CalcularSueldoBruto();
            double sueldoNeto = CalcularSueldoNeto();

            return $"Nombres: {Nombres}\r\nDNI: {DNI}\r\nCargo: {Cargo}\r\nÁrea: {Area}\r\nAños de Antigüedad: {AniosAntiguedad}\r\nSueldo Base: {sueldoBase}\r\nSueldo Bruto: {sueldoBruto}\r\nSueldo Neto: {sueldoNeto}";
        }
    }
}
