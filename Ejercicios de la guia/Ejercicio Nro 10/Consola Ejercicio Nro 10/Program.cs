using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ejercicio_Nro_10;

namespace Consola_Ejercicio_Nro_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numeroAux;
            int contador = 0;
            int min = 0;
            int max = 0;
            int flag = 0;
            int sumatoria = 0;
            while(contador<10)
            {

                Console.WriteLine("Ingrese un numero de -100 a 100");
                numeroAux = int.Parse(Console.ReadLine());
                if (Validaciones.Validar(numeroAux, -100, 100))
                {
                    sumatoria = sumatoria + numeroAux;
                    numero = numeroAux;
                    contador++;
                    if(flag==0)
                    {
                        flag = 1;
                        min = numero;
                        max = numero;
                    }
                    else
                    {
                        if(min>numero)
                        {
                            min = numero;
                        }
                        if(max<numero)
                        {
                            max = numero;
                        }
                    }


                }
                else
                {
                    Console.WriteLine("El numero ingresado es incorrecto");
                }


            }

            Console.WriteLine("Minimo: {0} \nMaximo {1} \nPromedio {2}",min,max,((double)sumatoria/10));

            Console.Beep();
            Console.ReadKey();
        }
    }
}
