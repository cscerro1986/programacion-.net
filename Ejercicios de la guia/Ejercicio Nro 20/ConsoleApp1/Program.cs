using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Pesos peso1= new Pesos(20000);

            Dolar dola1 = (Dolar)peso1;

            Euro euro1 = (Euro)peso1;

            Dolar d2 = new Dolar(15000);
            Euro e2 = (Euro)d2;
            Pesos p2 = (Pesos)d2;

            Console.WriteLine("La cantidad de Euros es {0:0.##}",  euro1.GetCantidad());
            Console.WriteLine("La cantidad de dolares es {0:0.##}", dola1.GetCantidad());


            Console.WriteLine("\nDolares:{0:0.##}", d2.GetCantidad());
            Console.WriteLine("Euros: {0:0.##}", e2.GetCantidad());
            Console.WriteLine("Pesos: {0:0.##}", p2.GetCantidad());

            if(d2==e2)
            {
                Console.WriteLine("Entro bien... son iguales");
            }
            else
            {
                Console.WriteLine("No entro bien... son distintos.");
            }



            Console.Beep();
            Console.ReadKey();
            Console.Clear();

            Dolar d3 = new Dolar(50);
            Pesos p3 = new Pesos(50000);
            Euro e3 = new Euro(8000);

            Pesos p4 = p3 + d3; 

            //Console.WriteLine("La suma de los 3 es: {0:0,##}", p4.GetCantidad());
            Console.WriteLine("La suma de los 3 es: {0}", p4.GetCantidad());

            Euro e4 = e3 - p3+d3;

            Console.WriteLine("La suma de dolares es {0}",e4.GetCantidad());
            Console.Beep();
            Console.ReadKey();



        }
    }
}
