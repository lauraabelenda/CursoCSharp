using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Clase para medir el tiempo transcurrido en la consulta
            Stopwatch reloj = new Stopwatch();
            ctrPresentacion13 control = new ctrPresentacion13();
            control.LlenarLista();
            Impresion.ImprimeProductos(control.Productos);
            Impresion.EsperaTecla();
            List<clsProductosInventario> lista = new List<clsProductosInventario>();
            reloj.Start();
            
            //Agregar productos a la lista con existencias menor o igual a 0.
            foreach (var item in control.Productos)
            {
                if (item.Existencias > 0 && item.PrecioPublico < 12)
                    lista.Add(item);
            }
            reloj.Stop();

            // Imprime la consulta de los productos con el anterior foreach
            Impresion.ImprimeProductos(lista);
            Impresion.ImprimeTiempo(reloj.ElapsedMilliseconds);
            Impresion.EsperaTecla();

            /*
             * Consultar los productos con el lenguaje linq
             */
            List<clsProductosInventario> lista2 = new List<clsProductosInventario>();
            reloj.Reset();
            reloj.Start();
            //Consulta de los productos mediante linq, la consulta es más lenta que un foreach
            lista2.AddRange(from o in control.Productos where o.Existencias > 0 && o.PrecioPublico < 12 select o);
            reloj.Stop();
            Impresion.ImprimeProductos(lista2);
            Impresion.ImprimeTiempo(reloj.ElapsedTicks);
            Impresion.EsperaTecla();

            /*
             * Utilizar group by para agrupar los productos por su costo y obtener la suma de elementos con una expresión lambda
             */

            var lista3 = (from o in control.Productos group o by o.Costo into g select new { g.Key, Total = g.Sum(t => t.Existencias*t.PrecioPublico) }).ToList();
            foreach (var item in lista3)
            {
                Console.WriteLine("Total: {0} Costo: {1} ",item.Total, item.Key);
            }
            Console.ReadKey();

        }
    }
}
