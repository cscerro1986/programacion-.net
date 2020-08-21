using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_12
{
    public class ValidarRespuesta
    {

        public static bool ValidaS_N (char c)
        {
            bool retorno = false;
            if(c=='S')
            {
                retorno = true;
            }

            return retorno;
        }


    }
}
