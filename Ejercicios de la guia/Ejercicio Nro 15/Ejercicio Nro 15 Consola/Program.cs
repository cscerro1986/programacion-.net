using Ejercicio_Nro_15;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            char operacion;
            double numero1;
            double numero2;
            double resultado = double.NaN;

            while (continuar=='s')
            {
                Console.WriteLine("Indique la operacion que desea realizar");
                operacion= char.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el primer numero");
                numero2 = int.Parse(Console.ReadLine());

                if(operacion=='/')
                {
                    if(Calculadora.Validar(numero2))
                    {
                        resultado = Calculadora.Calcular(numero1, numero2, operacion);
                        Console.WriteLine("El resultado es: {0}", resultado);
                    }
                    else
                    {
                        Console.WriteLine("El dividendo debe ser distinto de 0");
                        
                    }
                }
                else
                {
                    resultado = Calculadora.Calcular(numero1, numero2, operacion);
                    Console.WriteLine("El resultado es: {0}", resultado);
                }

                Console.WriteLine("Desea continuar? s-n");
                continuar = char.Parse(Console.ReadLine());
            }

            Console.Beep();
            Console.ReadKey();


        }
    }
}
