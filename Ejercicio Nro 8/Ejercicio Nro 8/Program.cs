using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Ejercicio  Nro 8";

            double valorHora;
            string nombre;
            int antiguedad;
            int cantidadDeHorasTrabajadas;
            double bruto;
            double neto;

            Console.WriteLine("Ingrese el valor de la hora");
            valorHora = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Antiguedad");
            antiguedad = int.Parse(Console.ReadLine());
            Console.WriteLine("Horas trabajadas");
            cantidadDeHorasTrabajadas = int.Parse(Console.ReadLine());

            bruto = CalculoSalarioBruto(cantidadDeHorasTrabajadas, valorHora, antiguedad);
            neto = bruto * 0.87;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\n***************************************************************");
            sb.AppendLine("***********************Recibo de sueldo************************");
            sb.AppendLine("Nombre: "+nombre);
            sb.AppendLine("Antiguedad: " + antiguedad);
            sb.AppendLine("Valor hora: " + valorHora);
            sb.AppendLine("Cantidad de horas: " + cantidadDeHorasTrabajadas);
            sb.AppendLine("Importe bruto: " + bruto);
            sb.AppendLine("Importe neto: " + neto);
            sb.AppendLine("***************************************************************");

            Console.WriteLine(sb.ToString());

            Console.Beep();
            Console.ReadKey();
        }

        public static double CalculoSalarioBruto(int cantidadHoras, double valorHora, int antiguedad)
        {
            double retorno = 0 ;

            retorno = ((cantidadHoras * valorHora) + (150 * antiguedad));

            return retorno;
        }
    }
}
