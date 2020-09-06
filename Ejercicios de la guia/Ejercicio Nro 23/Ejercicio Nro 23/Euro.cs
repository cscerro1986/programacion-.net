using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        static double cotizRespectorDolar;


        static Euro()
        {
            cotizRespectorDolar = 0.93;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion):this(cantidad)
        {
            cotizRespectorDolar = cotizacion;
        }
        
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static void SetCotizacion(double coti)
        {
            cotizRespectorDolar = coti;
        }


        public static double GetCotizacion()
        {
            return cotizRespectorDolar;
        }

        #region OPERADORES


        /// <summary>
        /// Casteo de Euro a Dolar
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Dolar(Euro e)
        {

            return new Dolar(e.GetCantidad() / Euro.GetCotizacion());

        }

        /// <summary>
        /// Castea de Euro a Pesos,
        /// </summary>
        /// <param name="e"></param>
        public static explicit operator Pesos(Euro e)
        {
            //Dolar dolarAux = (Dolar)e;
            //Pesos pesoAux = (Pesos)dolarAux;
            //return pesoAux;
            
            //Se castea de Euro a Dolar y de Dolar a Peso.

            return (Pesos)((Dolar)e);

        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() + ((Euro)(Dolar)p).GetCantidad());
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.GetCantidad() - ((Euro)(Dolar)p).GetCantidad());
        }




        public static bool operator == (Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1 ,Euro e2)
        {
            return !(e1==e2);
        }


        public static bool operator ==(Euro e, Pesos p)
        {
            return e.GetCantidad() == ((Euro)((Dolar)p)).GetCantidad();
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }



        public static bool operator ==(Euro e, Dolar d)
        {
            return e.GetCantidad() == ((Euro)d).GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }


        #endregion OPERADORES



    }
}
