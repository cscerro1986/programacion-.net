using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";


            Console.WriteLine("primero 4 numeros perfectos");
            int limite = 4;
            int numero = 1;
            while(limite>0)
            {
                if (EsPerfecto(numero))
                {
                    limite--;
                    Console.WriteLine(numero);
                }
                numero++;
            }

            
            Console.ReadKey();

        }

        public static bool EsPerfecto( int numero)
        {
            bool retorno = false;
            int acumulador = 0;
            if(numero>0 )
            {
                for(int i=1;i<numero;i++)
                {
                    if(EsDivisor(numero,i))
                    {
                        acumulador = acumulador + i;
                    }
                }

                if(acumulador==numero)
                {
                    retorno = true;
                }

            }

            return retorno;

        }

        public static bool EsDivisor( int dividendo, int divisor)
        {
            bool retorno = false;


            if((dividendo%divisor)==0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
