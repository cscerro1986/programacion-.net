using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Nro_13;

namespace ConsoleEjercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 4566456;
            string numeroBinario;
            int retorno = 0;

            numeroBinario = Conversor.DecimalBinario(numero);

            retorno = Conversor.BinarioDecimal(numeroBinario);


            Console.WriteLine("Numero binario "+numeroBinario);
            Console.WriteLine("Numero Decimal "+retorno);

            Console.Beep();
            Console.ReadKey();


        }
    }
}
