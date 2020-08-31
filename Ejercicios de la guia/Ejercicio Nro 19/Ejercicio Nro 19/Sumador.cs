using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_19
{
    public class Sumador
    {
        private int CantidadSumas;

        public Sumador() : this(0)
        {

        }

        public Sumador(int cantidadSumas)
        {
            this.CantidadSumas = cantidadSumas;
        }


        /// <summary>
        /// Concatena y retorna dos cadenas de texto, aumenta en 1 la cantidad de Sumas realizadas.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Sumar(string a, string b)
        {

            this.CantidadSumas++;

            return a + b;

        }


        /// <summary>
        /// Suma dos numeros de tipo Long y los retorna. A su vez suma en 1 la cantidad de Sumas realizadas.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Sumar(long a, long b)
        {
            this.CantidadSumas++;
            return a + b;
        }

        #region OPERADORES


        /// <summary>
        /// Suma la cantidad de Sumas de a y Cantidad de Sumas de b.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static long operator +(Sumador a, Sumador b)
        {
            return a.CantidadSumas + b.CantidadSumas;
        }



        /// <summary>
        /// Retorna true si las cantidadSumas de Sumador a es igual a Sumador b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator |(Sumador a, Sumador b)
        {
            return a.CantidadSumas == b.CantidadSumas;
        }




        #endregion OPERADORES
    }
}
