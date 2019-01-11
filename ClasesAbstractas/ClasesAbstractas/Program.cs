using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesBase cliente = new clsClientesBase(0, "Laura Abelenda",
                "001", "HEHM", 1,"Laura Abelenda");
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        
        }
    }
}
