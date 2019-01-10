using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularidadYEncapsulamineto
{
    public class clsEmpleados
    {
        public clsEmpleados()
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        private string _Nombre;

        public int Edad { get; set; }

        public string Nombre { get => _Nombre; set => _Nombre = value; }

        public decimal SueldoDiario { get; set; }

        public decimal CalcularSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }
    }
}
