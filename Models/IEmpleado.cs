using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_2.Models
{
    interface IEmpleado
    {
        int CalcularAntiguedad();
        double CalcularSalario();
    }
}
