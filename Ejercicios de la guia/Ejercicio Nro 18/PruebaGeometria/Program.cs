using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(-7, 2);
            Punto punto3 = new Punto(4, 8);

            Rectangulo rec1 = new Rectangulo(punto1, punto3);
            float area = rec1.Area();
            float perimetro = rec1.Perimetro();


            Console.WriteLine("El area {0}",area);
            Console.WriteLine("Perimetro {0}",perimetro);

            Console.ReadKey();
            

        }
    }
}
