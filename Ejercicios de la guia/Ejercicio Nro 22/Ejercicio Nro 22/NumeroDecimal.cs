using Ejercicio_Nro_13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_22
{
    public class NumeroDecimal
    {
        double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero()
        {
            return this.numero;
        }


        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            string aux = b + d;
            return (double)Conversor.BinarioDecimal(aux);
        }
        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            double aux = (d.GetNumero() - (Conversor.BinarioDecimal(b.GetNumero())));
            return aux;
        }

        public static implicit operator NumeroDecimal (double d)
        {
            return new NumeroDecimal(d);
        }

        public static explicit operator NumeroDecimal (NumeroBinario b)
        {
            return new NumeroDecimal(Conversor.BinarioDecimal(b.GetNumero()));
        }


    }
}
