using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Nro_12;

namespace ConsoleEjercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar=true;
            int numero = 0;
            int numeroAux = 0;
            while (continuar==true)
            {
                Console.WriteLine("Ingrese un numero por favor");
                numeroAux =int.Parse(Console.ReadLine());
                numero = numero + numeroAux;

                Console.WriteLine("Desea Continuar? S-N");
                continuar = ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine()));

            }
            Console.WriteLine("La suma es de: "+numero);
            Console.ReadKey();

        }
    }
}
