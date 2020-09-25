using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_28
{
    public class DiccionarioDePalabras
    {
        private Dictionary<string, int> diccionarioDePalabras;

        public DiccionarioDePalabras(Dictionary<string, int> diccionarioDePalabras)
        {
            this.diccionarioDePalabras = diccionarioDePalabras;
            
        }


        public static void AgregarPalabra(Dictionary<string,int> diccionario, string palabraAAgregar)
        {
            foreach (KeyValuePair<string,int> item in diccionario)
            {
                if(item.Key==palabraAAgregar)
                {
                    string stringAux = item.Key;
                    int intAux = item.Value;
                    diccionario.Remove(item.Key);
                    diccionario.Add(stringAux, intAux + 1);
                    break;
                }
                else
                {
                    diccionario.Add(palabraAAgregar, 1);

                }
            }
        }

        
        public static List<string> DeStringAListaDePalabras( string linea)
        {
            string[] arrayString = DeStringALista(linea);
            List<string> lista = new List<string>();

            foreach (string item in arrayString)
            {
                lista.Add(item);
            }
            return lista;
            
        }

        public static string[] DeStringALista(string linea)
        {

            string[] substring = linea.Split(' ');

            return substring;

        }

        public static bool ExisteEnElDiccionario(Dictionary<string, int> dic, string palabra)
        {
            foreach (KeyValuePair<string, int> item in dic)
            {
                if (item.Key == palabra)
                    return true;
            }

            return false;
        }

        public static void AgregarOSumarPalabra(Dictionary<string, int> diccionario, string palabra)
        {
            if (ExisteEnElDiccionario(diccionario, palabra))
            {
                int aux;
                if (diccionario.TryGetValue(palabra, out aux))
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

        private static string[] DeStringALista2(string linea)
        {

            string[] substring = linea.Split(' ');

            return substring;

        }

        public static string CambiarPuntoPorEspacio(string linea)
        {
            int posicion = 0;
            string lineaAux = linea.Trim();
            int largo = lineaAux.Length;

            if(linea.Contains("."))
            {

                for (int i = 0; i < largo; i++)
                {
                    if (lineaAux[i] == '.')
                    {
                        posicion = i;
                        break;
                    }
                }
                lineaAux = lineaAux.Remove(posicion);
            }


            return lineaAux;
        }

        public static List<string> BorrarPuntos(List<string> listainicial)
        {
            List<string> listaAux = new List<string>();
            string aux = string.Empty;

            foreach (string item in listainicial)
            {
                aux = CambiarPuntoPorEspacio(item);
                listaAux.Add(aux);
            }
            return listaAux;
        }


    }
}
