using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_11
{
    public class Validaciones
    {

        /// <summary>
        /// Recibe 3 parametros, un valor, un minimo y un maximo.
        /// Si el valor se encuentra entre el minimo y el maximo retornara TRUE, de lo contrario retornara FALSE
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;

            if(valor>=min&&valor<=max)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
