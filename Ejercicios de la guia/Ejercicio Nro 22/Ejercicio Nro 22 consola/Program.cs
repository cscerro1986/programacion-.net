using Ejercicio_Nro_22;
using System;
using System.Text;

namespace Ejercicio_Nro_22_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroDecimal nd1 = 22;
            NumeroBinario nb1 = "1100110";
            NumeroBinario nb2 = (NumeroBinario)nd1;

            NumeroDecimal nd2 = (NumeroDecimal)nb1;
            NumeroDecimal nd3 = nd1 + nb1;
            NumeroBinario nb3 = nb1 + nd1;

            if (nb3 == nd3)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }



            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************************************");
            sb.AppendFormat("Numero decimal: {0} \n", nd1.GetNumero());
            sb.AppendFormat("Numero Binario: {0} \n", nb1.GetNumero());
            sb.AppendFormat("Numero Binario pasado a Decimal :{0}\n", nb2.GetNumero());
            sb.AppendFormat("Numero Decimal pasado a Binario  :{0}\n", nd2.GetNumero());
            sb.AppendFormat("Suma 1 {0}\n", nd3.GetNumero());
            sb.AppendFormat("Suma 2 {0}\n", nb3.GetNumero());

            Console.WriteLine(sb.ToString());
            Console.Beep();
            Console.ReadKey();


        }

    }
}
