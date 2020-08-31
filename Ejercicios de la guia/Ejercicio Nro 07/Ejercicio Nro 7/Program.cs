using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




        /*
         * Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
         * calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
         * con DateTime.Now).
         * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
         */

namespace Ejercicio_Nro_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 7";
            string fechaString;
            
            Console.WriteLine("Ingrese su fecha de nacimiento (DDMMAAAA)");
            fechaString = Console.ReadLine();
            
            DateTime fechaDeNacimiento = DeStringADateTime(fechaString);
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine(CalcularDiasTranscurridos(fechaDeNacimiento,fechaActual));

            Console.Beep();
            Console.ReadKey();


        }

        public static DateTime DeStringADateTime(string fecha)
        {
            string dia = fecha.Substring(0, 2);
            string mes = fecha.Substring(2, 2);
            string anio = fecha.Substring(4, 4);

            DateTime fechaRetorno = new DateTime(int.Parse(anio), int.Parse(mes), int.Parse(dia));

            return fechaRetorno;

        }

        public static int CalcularDiasTranscurridos(DateTime fecha1, DateTime fecha2)
        {
            int retorno = 0;

            int anio1 = fecha1.Year;
            int mes1 = fecha1.Month;
            int dias1 = fecha1.Day;
            int anio2 = fecha2.Year;
            int mes2 = fecha2.Month;
            int dias2 = fecha2.Day;

            if((anio2-anio1)==0)
            {
                retorno = ((DiasTranscurridosDelAñio(fecha2) - DiasTranscurridosDelAñio(fecha1)));
                return retorno;

            }

            if((anio2-anio1)==1)
            {
                if(EsBiciesto(anio1))
                {
                    retorno = 366 - DiasTranscurridosDelAñio(fecha1) + DiasTranscurridosDelAñio(fecha2);
                    return retorno;
                }
                else
                {
                    retorno = 365 - DiasTranscurridosDelAñio(fecha1) + DiasTranscurridosDelAñio(fecha2);
                    return retorno;
                }

            }

            if((anio2-anio1)>=2)
            {
                if (EsBiciesto(anio1))
                {
                    retorno = 366 - DiasTranscurridosDelAñio(fecha1) + DiasTranscurridosDelAñio(fecha2);
                    
                }
                else
                {
                    retorno =365 - DiasTranscurridosDelAñio(fecha1) + DiasTranscurridosDelAñio(fecha2);
                }

                for (int i = (anio1+1);i<anio2;i++)
                {
                    if(EsBiciesto(i))
                    {
                        retorno = retorno + 366;
                    }    
                    else
                    {
                        retorno = retorno + 365;
                    }
                }
            }



            return retorno;
        }


        /// <summary>
        /// Se ingresa una fecha y te retorna la cantidad de dias que transcurrieron del año.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static int DiasTranscurridosDelAñio(DateTime fecha)
        {
            int anio = fecha.Year;
            int mes = fecha.Month;
            int dia = fecha.Day;
            int retorno = 0;

            switch(mes)
            {
                case 1:
                    retorno = 0;
                    break;
                case 2:
                    retorno = 31;
                    break;
                case 3:
                    if(EsBiciesto(anio))
                    {
                        retorno = 60;
                    }
                    else
                    {
                        retorno = 59;
                    }
                    break;
                case 4:
                    if (EsBiciesto(anio))
                    {
                        retorno = 91;
                    }
                    else
                    {
                        retorno = 90;
                    }
                    break;
                    
                case 5:
                    if (EsBiciesto(anio))
                    {
                        retorno = 121;
                    }
                    else
                    {
                        retorno = 120;
                    }
                    break;
                case 6:
                    if (EsBiciesto(anio))
                    {
                        retorno = 152;
                    }
                    else
                    {
                        retorno = 151;
                    }
                    break;
                case 7:
                    if (EsBiciesto(anio))
                    {
                        retorno = 182;
                    }
                    else
                    {
                        retorno = 181;
                    }
                    break;
                case 8:
                    if (EsBiciesto(anio))
                    {
                        retorno = 213;
                    }
                    else
                    {
                        retorno = 212;
                    }
                    break;
                case 9:
                    if (EsBiciesto(anio))
                    {
                        retorno = 244;
                    }
                    else
                    {
                        retorno = 243;
                    }
                    break;
                case 10:
                    if (EsBiciesto(anio))
                    {
                        retorno = 274;
                    }
                    else
                    {
                        retorno = 273;
                    }
                    break;
                case 11:
                    if (EsBiciesto(anio))
                    {
                        retorno = 305;
                    }
                    else
                    {
                        retorno = 304;
                    }
                    break;
                case 12:
                    if (EsBiciesto(anio))
                    {
                        retorno = 335;
                    }
                    else
                    {
                        retorno = 334;
                    }
                    break;

            }

            retorno = retorno + dia;

            return retorno;

        }

        /// <summary>
        /// Determina si el año ingresado es Biciesto o no retornando True si lo es, y False si no.
        /// </summary>
        /// <param name="anio"></param>
        /// <returns></returns>
        public static bool EsBiciesto(int anio)
        {
            bool retorno = false;
            if (anio % 4 == 0)
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
