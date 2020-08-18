using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";

            int numero;
            int sumatoria = 0;
            int minimo = 0;
            int maximo = 0;
            int flag1 = 0;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Imgrese un numero entero");
                numero = int.Parse(Console.ReadLine());

                if(flag1==0)
                {
                    minimo = numero;
                    maximo = numero;
                    flag1 = 1;
                }

                if(flag1==1 && minimo>numero)
                {
                    minimo = numero;
                }

                if(flag1==1 && maximo<numero)
                {
                    maximo = numero;
                }



                sumatoria = sumatoria + numero;

            }



            Console.WriteLine("El numero maximo es {0}, el minimo es {1} y el promedio es {2} ",maximo,minimo,((float)sumatoria/5));
            Console.ReadKey();

        }
    }
}
