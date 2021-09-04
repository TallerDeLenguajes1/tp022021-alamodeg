using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_2.Models
{
    partial class Empleado : IEmpleado
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int Dni { get; set; }
        int AnioIngreso { get; set; }
        double Sueldo { get; set; }

        public Empleado(string nombre, string apellido, int dni, int anioIngreso, double sueldo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            AnioIngreso = anioIngreso;
            Sueldo = sueldo;
        }


        readonly float sueldoBasico = 25000;
        readonly double descuento = 0.15;
        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - AnioIngreso;
        }

        //Salario = Sueldo Básico + Adicional – Descuento
        public double CalcularSalario()
        {
            return sueldoBasico + GetAdicional(CalcularAntiguedad()) - (sueldoBasico * descuento);
        }

        //FALTA CONTROL ANTIGUEDAD 0
        public double GetAdicional(int antiguedad)
        {
            if (antiguedad >= 1 && antiguedad <= 20)
            {
                return sueldoBasico * antiguedad / 100;
            }
            if (antiguedad > 20)
            {
                return sueldoBasico * (antiguedad * 0.25);
            }
            else return -999;
        }
    }
}
