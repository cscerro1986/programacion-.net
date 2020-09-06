using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_Nro_13;

namespace Ejercicio_Nro_22
{
    public class NumeroBinario
    {
        string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return this.numero;
        }


        #region operadores

        public static string operator +(NumeroBinario b, NumeroDecimal d)
        {
            string retorno = "";

            int decimalAux = Conversor.BinarioDecimal(b.GetNumero());
            retorno = Conversor.DecimalBinario((decimalAux + (int)d.GetNumero()));
            return retorno;
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            string retorno = "";

            int decimalAux = Conversor.BinarioDecimal(b.GetNumero());
            retorno = Conversor.DecimalBinario((decimalAux - (int)d.GetNumero()));
            return retorno;
        }

        public static bool operator ==(NumeroBinario b, NumeroDecimal d)
        {
            return (int)d.GetNumero() == Conversor.BinarioDecimal(b.GetNumero());
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b==d);
        }

        public static implicit operator NumeroBinario(string b)
        {
            return new NumeroBinario(b);
        }

        public static explicit operator NumeroBinario (NumeroDecimal d)
        {
            return new NumeroBinario(Conversor.DecimalBinario((int)d.GetNumero()));
        }


        #endregion operadores

    }
}
