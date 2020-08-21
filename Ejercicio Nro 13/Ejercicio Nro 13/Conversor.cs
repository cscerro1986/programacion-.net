using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_13
{
    public class Conversor
    {

        public static string DecimalBinario(int numero)
        {
            string retorno ="";
            
            while(numero>3)
            {
                if(numero%2==0)
                {
                    retorno = "0" + retorno;
                }
                if(numero%2==1)
                {
                    retorno = "1" + retorno;
                }

                numero = numero / 2;

            }
            if(numero==3)
            {
                retorno = "11" + retorno;
            }
            if(numero==2)
            {
                retorno = "10" + retorno;
            }
            

            return retorno;

        }

        public static int BinarioDecimal(string binario)
        {

            int retorno = 0;
            int enteroAux = 0;
            int len = binario.Length;
            double auxDouble = 0;

            for (int i = 0; i < len; i++)
            {
                enteroAux = int.Parse(binario.Substring(i, 1));
                if (!(enteroAux == 0|| enteroAux == 1))
                {
                    return -1;
                }
                else
                {
                    
                    auxDouble = Math.Pow(2, len - i - 1);

                    retorno = retorno + (Convert.ToInt32(auxDouble) * enteroAux);
                }
            }
            return retorno;
        }

    }
}
