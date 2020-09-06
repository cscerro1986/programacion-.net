using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_26_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            int cantidad = 20;
            int[] listaDeInt = new int[cantidad];

            Random rd = new Random();

            for(int i=0;i<cantidad;i++)
            {
                listaDeInt[i] = rd.Next();
            }

            foreach (int item in listaDeInt)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
