using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliforfismo
{
    public class clsArchivos : intSalidas
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            StreamWriter archivo = new StreamWriter(@"C:\Users\i8592\Desktop\Archivos\ArchivosBit.txt", true);
            archivo.WriteLine(cliente.TipoRegimen == 1);
            if (cliente.TipoRegimen == 1)
                archivo.WriteLine("Tipo: PERSONA FISICA");
            else
                archivo.WriteLine("Tipo: PERSONA MORAL");

            archivo.WriteLine("RFC: " + cliente.RFC);
            archivo.Close();

        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            StreamWriter archivo = new StreamWriter(@"C:\Users\i8592\Desktop\Archivos\ArchivosBit.txt", true);
            archivo.Close();
        }
    }
}
