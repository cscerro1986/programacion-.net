using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio_Nro_19;

namespace Ejercicio_Nro_19_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador1 = new Sumador();
            Sumador sumador2 = new Sumador();

            Console.WriteLine(sumador1.Sumar("SANTIAGO ", "CERRO"));
            Console.WriteLine("El resultado es "+sumador1.Sumar(3,6));
            Console.WriteLine("\n");
            Console.WriteLine(sumador2.Sumar("SANTIAGO ", "CERRO"));
            Console.WriteLine("El resultado es " + sumador2.Sumar(4, 6));
            Console.WriteLine("\nLa cantidad de sumas es {0}",(sumador1+sumador2));

            Console.ReadKey();


        }
    }
}
