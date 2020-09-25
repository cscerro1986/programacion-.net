using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_28
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> listaDeNumero = new List<int>();
            List<int> listaDeNumero2 = new List<int>();
            
            int cantidad = 10;
            Random rn = new Random();


            //listaDeNumero2 = listaDeNumero;
            //for (int i = 0; i < cantidad; i++)
            //{
            //    listaDeNumero.Add(rn.Next(int.MinValue, int.MaxValue));
            //}

            //foreach (int item in listaDeNumero)
            //{
            //    Console.WriteLine(item);
            //}

            //listaDeNumero2.Sort();
            //listaDeNumero2.Reverse();
            //Console.WriteLine("\n\n");
            //foreach (int item in listaDeNumero2)
            //{
            //    if (item > 0)
            //        Console.WriteLine(item);
            //}
            //listaDeNumero2.Reverse();
            //Console.WriteLine("\n\n");
            //foreach (int item in listaDeNumero2)
            //{
            //    if (item < 0)
            //        Console.WriteLine(item);
            //}




            //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            Stack<int> listaStack = new Stack<int>();
            //foreach (int item in listaDeNumero)
            //{
            //    Console.WriteLine(item);
            //    listaStack.Push(item);
            //}



            for (int i = 0; i < cantidad; i++)
            {
                listaStack.Push(rn.Next(int.MinValue, int.MaxValue));
            }
            foreach (int item in listaStack)
            {
                Console.WriteLine(item);
            }

            


            listaStack.Reverse();
            Console.WriteLine("\n");
            foreach (int item in listaStack)
            {
                if (item > 0)
                    Console.WriteLine(item);
            }

            Console.WriteLine("\n");

            listaStack.Reverse();
            foreach (int item in listaStack)
            {
                if (item < 0)
                    Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
