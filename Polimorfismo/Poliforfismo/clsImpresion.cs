using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliforfismo
{
    public class clsImpresion
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            Console.WriteLine(cliente.Clave + " " + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        }
    }
}
