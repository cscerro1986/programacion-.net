using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            double numero1;
            double numero2;
            double area;

            Console.WriteLine("Cuadrado");
            Console.WriteLine("Ingrese el largo de un lado");
            numero1 = double.Parse(Console.ReadLine());

            area = CalculoDeArea.CalcularCuadrado(numero1);
            Console.WriteLine("El area del cuadrado es: {0}",area);
            Console.Beep();
            Console.ReadKey();

            Console.WriteLine("Triangulo");
            Console.WriteLine("Ingrese el largo de un lado");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el largo de un lado");
            numero2 = double.Parse(Console.ReadLine());


            area = CalculoDeArea.CalcularTriangulo(numero1, numero2);
            Console.WriteLine("El area del cuadrado es: {0}", area);

            Console.Beep();
            Console.ReadKey();


            Console.WriteLine("Circulo");
            Console.WriteLine("Ingrese el diametro");
            numero1 = double.Parse(Console.ReadLine());
            area = CalculoDeArea.CalcularCirculo(numero1);
            Console.WriteLine("El area del cuadrado es: {0}", area);



            Console.Beep();
            Console.ReadKey();


        }
    }
}
