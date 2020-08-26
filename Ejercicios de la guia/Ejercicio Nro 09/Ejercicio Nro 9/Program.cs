using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int altura;

            Console.WriteLine("Ingrese la altura");

            altura = int.Parse(Console.ReadLine());
            string asterisco = "*";
            int contador = 1;

            for(int i=0;i<altura;i++)
            {
                
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < contador; j++)
                    {
                        sb.Append(asterisco);
                    }

                    Console.WriteLine(sb.ToString());
                
                contador = contador + 2;

            }

            Console.Beep();

            Console.ReadKey();
        }


    }
}
