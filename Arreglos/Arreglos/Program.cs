using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arreglo = new int[12];
            int i;
            string cadena;
            for (i = 0; i < 12; i++)
            {
                cadena = Console.ReadLine();
                Arreglo[i] = Convert.ToInt32(cadena);
            }
            for (i = 0; i < 12; i++)
            {
                Console.WriteLine("{0}", Arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
