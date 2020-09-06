using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Nro_21;

namespace Ejercicio_Nro_21_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Celsius c1 = new Celsius(100);
            //    Kelvin k1;
            //    Fahrenheit f1;

            //    f1 = (Fahrenheit)c1;
            //    k1 = (Kelvin)f1;
            //    Celsius c2 = (Celsius)f1;
            //    Fahrenheit f2 = (Fahrenheit)c2;
            //    Kelvin k2 = (Kelvin)f2;

            //    Console.WriteLine("Grados Celcius: {0} equivale a {1} grados Farenheit",c1.GetTemperatura(),f1.GetTemperatura());
            //    Console.WriteLine("Grados Kelvin {0}",k1.GetTemperatura());
            //    Console.WriteLine("Celcius {0}",c2.GetTemperatura());
            //    Console.WriteLine("Farenhait {0}",f2.GetTemperatura());
            //    Console.WriteLine("Kelvin {0} ",k2.GetTemperatura());


            Celsius c1 = new Celsius(100);
            Fahrenheit f1 = (Fahrenheit)c1;
            Kelvin k1 = (Kelvin)c1;
            Console.WriteLine("Kelvin: {0} \nFaren {1}",f1.GetTemperatura(),k1.GetTemperatura());


            Console.ReadKey();


        }
    }
}
