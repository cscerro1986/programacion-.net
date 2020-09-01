using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Fahrenheit
    {
        private double temperatura;

        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }

        public double GetTemperatura()
        {
            return this.temperatura;

        }

        public static double DeFarenhaitACelsius(double f)
        {
            return ((f - 32) * 5 / 9);
        }
        public static double DeFarenhaitAKelvin( double f)
        {
            return ((f - 32) * 5 / 9) + 273.15;
        }

        public static explicit operator Celsius (Fahrenheit f)
        {
            return new Celsius(DeFarenhaitACelsius(f.GetTemperatura()));
        }

        public static explicit operator Kelvin (Fahrenheit f)
        {
            return new Kelvin(DeFarenhaitAKelvin(f.GetTemperatura()));
        }


    }
}
