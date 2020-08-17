using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";
            
            int numero1 ;
            int numero2 ;

            Console.WriteLine("Ingrese un numero");
            
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero");

            numero2 = int.Parse(Console.ReadLine());

            for(int i = numero1;i<=numero2;i++)
            {
                if(EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }

        public static bool EsPrimo(int numero)
        {
            bool retorno = false;
            int contador = 0;

            for (int i =1;i<=numero;i++)
            {
                if((numero%i)==0)
                {
                    contador++;
                }
            }
            if(contador==2)
            {
                retorno = true;
            }
            return retorno;
        }

    }
}
