using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nto 6";

            int anio1;
            int anio2;

            Console.WriteLine("Ingrese un primer anio");
            anio1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un segundo anio");
            anio2 = int.Parse(Console.ReadLine());

            for(int i=anio1;i<anio2;i++)
            {
                if(EsBiciesto(i))
                {
                    Console.WriteLine("Año biciesto: {0}",i);
                }    
            }

            Console.Beep();
            Console.ReadKey();

        }


        /// <summary>
        /// Determina si el año ingresado es Biciesto o no retornando True si lo es, y False si no.
        /// </summary>
        /// <param name="anio"></param>
        /// <returns></returns>
        public static bool EsBiciesto( int anio)
        {
            bool retorno = false;
            if(anio%4==0)
            {
                retorno = true;   
                    
            }

            if (anio % 100 == 0)
            {
                retorno = false;

                if (anio % 400 == 0)
                {
                    retorno = true;
                }

            }

            return retorno;

        }
    }
}
