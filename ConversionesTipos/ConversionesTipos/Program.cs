using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            decimal x = 12.2m;
            bool bandera = true;
            string cadena = "1234";
            DateTime fecha = DateTime.MinValue;

            /*Conversiones*/
            //x = i;
            //i = x;
            //i = (int)x;
            i = Convert.ToInt32(cadena);
            Console.WriteLine("El valor de i es: {0}", i);
            Console.WriteLine("El valor de x es: {0:C}", x);
            Console.WriteLine("El valor de bandera es: " + bandera.ToString());
            Console.WriteLine("El valor de cadena: " + cadena);
            Console.WriteLine("El valor de fecha: " + fecha.ToShortDateString());
            Console.ReadKey();
        }
    }
}
