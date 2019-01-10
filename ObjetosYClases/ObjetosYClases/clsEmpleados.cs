using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosYClases
{
    public class clsEmpleados
    {
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        public string Nombre;

        public decimal SueldoDiario;

        public int Edad;

        public decimal CalcularSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}
