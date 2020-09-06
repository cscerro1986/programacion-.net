using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Celsius
    {
        private double temperatura;
            
        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;
        
        }
        private static double DeCelciusAKelvin(double c)
        {
            double retorno = 0;

            retorno = c + 273.15;

            return retorno;
        }


        private static double DeCelciusAFarenheit(double c)
        {
            double retorno = 0;

            retorno = ((c * 9 / 5) + 32);

            return retorno;
        }






        private static double DeKelvinACelcius(double k)
        {
            double retorno = 0;

            retorno = k - 273.15;

            return retorno;
        }

        private static double DeFarnhaitACelcius(double F)
        {
            double retorno = 0;
            retorno = ((F - 32) * (5 / 9));
            
            return retorno;
        }
        
        public static explicit operator Kelvin( Celsius c)
        {
            Kelvin k = new Kelvin(DeCelciusAKelvin(c.GetTemperatura()));

            return k;
        }


        public static explicit operator Fahrenheit( Celsius c)
        {
            return new Fahrenheit(DeCelciusAFarenheit(c.GetTemperatura()));
        }


    }
}
