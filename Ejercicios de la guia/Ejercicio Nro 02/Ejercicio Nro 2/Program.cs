using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_Nro_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 2";
            bool verifica= false;
            int numero;
            string mensajeError = "ERROR, ¡Reingresar Numero!";
            Console.WriteLine("Ingrese un numero por favor");
            verifica=int.TryParse(Console.ReadLine(), out numero);
            
            if(verifica==false||numero<0)
            {
                Console.WriteLine(mensajeError);
            }
            else
            {
                Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}", numero, Math.Pow(numero, 2), Math.Pow(numero, 3));

            }

            Console.ReadKey();


        }
    }
}
