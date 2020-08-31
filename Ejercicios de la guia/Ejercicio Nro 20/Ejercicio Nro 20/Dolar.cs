using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        static double cotizRespectorDolar;

        static Dolar()
        {
            cotizRespectorDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectorDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectorDolar;
        }


        #region OPERADORES


        /// <summary>
        /// Casteo explicito de Dolar a Euro.
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Euro(Dolar d)
        {
            double cantidadEuro = (d.GetCantidad() * Euro.GetCotizacion());
            return new Euro(cantidadEuro);

            
        }


        /// <summary>
        /// Casteo Explicito de Dolar a Pesos
        /// </summary>
        /// <param name="d"></param>
        public static explicit operator Pesos(Dolar d)
        {

            double cantidadPesos = d.GetCantidad() * Pesos.GetCotizacion();

            return new Pesos(cantidadPesos);

        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad()+((Dolar)p).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }


        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }




        public static bool operator ==(Dolar d, Euro e)
        {
            Dolar dAux = (Dolar)e;

            return d.GetCantidad() == dAux.GetCantidad();
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d==e);
        }

        public static bool operator==(Dolar d, Pesos p)
        {
            Dolar dAux = (Dolar)p;

            return d.GetCantidad() == dAux.GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        

        #endregion OPERADORES

    }
}
