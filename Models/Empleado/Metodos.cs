using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_2.Models
{
    public partial class Empleado : IEmpleado
    {
        readonly float sueldoBasico = 25000;
        readonly double descuento = 0.15;
        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - AnioIngreso;
        }

        //Salario = Sueldo Básico + Adicional – Descuento
        public double CalcularSalario()
        {
            return sueldoBasico + getAdicional(CalcularAntiguedad()) - (sueldoBasico * descuento);
        }

        //FALTA CONTROL ANTIGUEDAD 0
        public double getAdicional(int antiguedad)
        {
            if (antiguedad>=1 && antiguedad<=20)
            {
                return sueldoBasico * antiguedad/100;
            }
            if (antiguedad > 20)
            {
                return sueldoBasico * (antiguedad * 0.25);
            }
            else return -999;
        }
    }
}
