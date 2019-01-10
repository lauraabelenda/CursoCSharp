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
            clsClientesConContacto cliente = new clsClientesConContacto(0, "Marcos Hernandez",
                                                                        "001",
                                                                        "HEHM",
                                                                        1, "Marcos Hernandez",
                                                                        "666666666",
                                                                        "666333333",
                                                                        "MH@yahoo.es",
                                                                        "Av Caidos",
                                                                        "124", "1","Chiapas",
                                                                        "Chiapas", "a","29096");
            clsImpresion Impresion;
            Impresion = new clsImpresion();
            Impresion.ImprimeCliente(cliente);
        }
    }
}
