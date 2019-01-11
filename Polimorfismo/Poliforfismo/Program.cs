using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliforfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Laura Abelenda",
                                                                        "001",
                                                                        "HEHM",
                                                                        1, "Laura Abelenda",
                                                                        "666666666",
                                                                        "666333333",
                                                                        "labelenda@sum.es",
                                                                        "Av asd",
                                                                        "124", "1","Chiapas",
                                                                        "Chiapas", "a","29096");
            intSalidas Impresion;
            string cadena = Console.ReadLine();
            if (cadena == "1")
                Impresion = new clsImpresion();
            else
                Impresion = new clsArchivos();
            Impresion.ImprimeCliente(cliente);
        }
    }
}
