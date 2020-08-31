using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 5";

            int contador = 0;
            int numeroCentro = 0;
            int numeroFinal = 0;
            int flag = 0;
            int SUMATORIA = 0;


            while(contador<4)
            {
                numeroFinal++;
                for(int i = 1;i<numeroFinal;i++)
                {
                    if(EsCentroNumerito(i,numeroFinal))
                    {   
                        contador++;
                        Console.WriteLine("El numero centro es el {0}",i);
                        numeroCentro = i;
                        for (int j = 0; j < numeroCentro; j++)
                        {
                            SUMATORIA = SUMATORIA + j;
                            Console.WriteLine("NUMERO: {0} y la sumatoria es {1} ",j,SUMATORIA);
                        }
                        SUMATORIA = 0;

                        for (int j = numeroCentro+1; j <= numeroFinal; j++)
                        {
                            SUMATORIA = SUMATORIA + j;
                            Console.WriteLine("NUMERO: {0} y la sumatoria es {1} ", j, SUMATORIA);

                        }

                        SUMATORIA = 0;
                        Console.Beep();
                        Console.ReadKey();
                    }
                    

                }
            }

            Console.ReadKey();
        }


        /// <summary>
        /// Verifica si numeroCentro es centro numerico hasta numeroFinal
        /// </summary>
        /// <param name="numeroCentro"></param>
        /// <param name="numeroFinal"></param>
        /// <returns></returns>
        public static bool EsCentroNumerito(int numeroCentro, int numeroFinal)
        {
            bool retorno = false;
            int acumuladorBajo = 0;
            int acumuladorAlto = 0;


            //calcula de 1 a centro numero
            for(int i=0;i<numeroCentro;i++)
            {
                acumuladorBajo = acumuladorBajo + i;
            }


            //calcular de centro numerico a numero final
            for (int i = numeroCentro+1 ; i <= numeroFinal; i++)
            {
                acumuladorAlto = acumuladorAlto + i;

            }


            // si es el mismo numero es centro numero
            if(acumuladorAlto==acumuladorBajo)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
