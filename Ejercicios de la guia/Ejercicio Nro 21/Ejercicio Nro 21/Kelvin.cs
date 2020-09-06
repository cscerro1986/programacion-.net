using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_21
{
    public class Kelvin
    {
        private double temperatura;

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }


        public double GetTemperatura()
        {
            return this.temperatura;

        }


        private static double DeKelvinACelcius( double k)
        {
            return k - 273.15;
        }

        private static double DeKelvinAFarenhaiet(double k)
        {
            return ((k-273.15)*9/5)+32;
        }

        public static explicit operator Celsius (Kelvin k)
        {
            return new Celsius(DeKelvinACelcius(k.GetTemperatura()));
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(DeKelvinAFarenhaiet(k.GetTemperatura()));
        }



    }
}
