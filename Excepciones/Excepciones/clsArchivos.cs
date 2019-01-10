using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class clsArchivos : intSalidas
    {
        public void ImprimeCliente(clsAbsClientes cliente)
        {
            int i = 0;
            bool bandera = true;
            while (bandera)
            {
                try
                {
                    StreamWriter archivo = new StreamWriter(@"C:\Users\i8592\Desktop\Archivos\ArchivosBit.txt", true);
                    archivo.WriteLine(cliente.TipoRegimen == 1);
                    if (cliente.TipoRegimen == 1)
                        archivo.WriteLine("Tipo: PERSONA FISICA");
                    else
                        archivo.WriteLine("Tipo: PERSONA MORAL");

                    archivo.WriteLine("RFC: " + cliente.RFC);
                    archivo.Close();
                    bandera = false;
                }
                catch (Exception e)
                {
                    i++;
                    if(i >= 200)
                        throw e;
                }
            }
            
            

        }

        public void ImprimeDireccion(clsDirecciones direccion)
        {
            StreamWriter archivo = new StreamWriter(@"C:\Users\i8592\Desktop\Archivos\ArchivosBit.txt", true);
            archivo.Close();
        }
    }
}
