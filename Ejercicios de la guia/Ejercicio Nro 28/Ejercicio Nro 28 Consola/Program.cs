using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_28_Consola
{
    class Program
    {
        static void Main(string[] args)
        {

            string frase = "De ese entrecruzamiento surge la información necesaria para saber no sólo qué porcentaje del total " +
                "de recursos recibe cada una de las 23 provincias y la Ciudad de Buenos Aires sino también cuál es el aporte que " +
                "cada distrito realiza a la economía argentina. Y, en consecuencia, quiénes se benefician al recibir más recursos " +
                "impositivos que el aporte económico que realizan y quiénes se perjudican por ser receptores de un porcentaje menor " +
                "a la proporción que tienen en la economía del país.";

            //CambiarPuntoPorEspacio(frase);

            //string[] lista = new string[1];

            string[] lista = DeStringALista2(frase);
           


            Console.WriteLine("Llegue hasta aca, palarbras totoales: {0}",lista.Length);

            Dictionary<string, int> dic = new Dictionary<string, int>();
            

            Console.Beep();
            Console.ReadKey();

            foreach (string item in lista)
            {
                AgregarOSumarPalabra(dic, item);
            }
            
            Console.Beep();
            Console.ReadKey();

            foreach (KeyValuePair<string, int> item in dic)
            {
                Console.WriteLine(item.Key + " "+ item.Value);
            }

            Console.Beep();
            Console.ReadKey();


        }

        public static bool ExisteEnElDiccionario(Dictionary<string, int> dic,string palabra)
        { 
            foreach (KeyValuePair<string,int> item in dic)
            {
                if (item.Key == palabra)
                    return true;
            }

            return false;
        }

        public static void AgregarOSumarPalabra(Dictionary<string, int>diccionario, string palabra)
        {
            if(ExisteEnElDiccionario(diccionario,palabra))
            {
                int aux;
                if (diccionario.TryGetValue(palabra, out aux));
                {
                    diccionario.Remove(palabra);
                    diccionario.Add(palabra, aux + 1);
                }
            }
            else
            {
                diccionario.Add(palabra, 1);
            }
        }

        public static string[] DeStringALista2(string linea)
        {

            string[] substring = linea.Split(' ');

            return substring;

        }

        public static string CambiarPuntoPorEspacio(string linea)
        {
            int posicion = 0;
            string lineaAux = linea.Trim();
            int largo = lineaAux.Length;

            for (int i =0;i<largo;i++)
            {
                if(lineaAux[i]=='.')
                {
                    posicion = i;
                    
                }
            }
            lineaAux = lineaAux.Remove(posicion);

            return lineaAux;
        }

    }
}
