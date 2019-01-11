using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuestraHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //clsMostrarArrayList arl;
            //arl = new clsMostrarArrayList();
            //arl.CapturarDatos();
            //arl.ImprimeDatos();

            clsMuestraHashTable MuestraH;
            MuestraH = new clsMuestraHashTable();
            MuestraH.AgregarDatos();
            MuestraH.ImprimirDatos();
            MuestraH.EliminarElemento("C001");
            MuestraH.ImprimirDatos();
        }
    }
}
