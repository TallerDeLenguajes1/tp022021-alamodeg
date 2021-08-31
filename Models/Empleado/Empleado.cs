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
    }
}
