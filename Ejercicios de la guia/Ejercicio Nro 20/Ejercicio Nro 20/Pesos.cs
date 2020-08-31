using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {

        public static double cotizRespectoDolar;
        private double cantidad;


        static Pesos()
        {
            cotizRespectoDolar = 66;
        }


        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion):this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        #region OPERADORES

        public static explicit operator Euro(Pesos p)
        {
            //Dolar dolarAux = (Dolar)p;
            //Euro euroAux = (Euro)dolarAux;

            //return euroAux;

            return (Euro)((Dolar)p);
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
            
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
        }


        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() + ((Pesos)((Dolar)e)).GetCantidad() );
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.GetCantidad() - ((Pesos)((Dolar)e)).GetCantidad());
        }




        public static bool operator ==(Pesos p, Dolar d)
        {
            Pesos pAux = (Pesos)d;
            return p.GetCantidad() == pAux.GetCantidad();
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p==d);
        }




        public static bool operator ==(Pesos p, Euro e)
        {
            Pesos pAux = (Pesos)e;
            return p.GetCantidad() == pAux.GetCantidad();
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }



        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }



        #endregion OPERADORES

    }
}
