using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_14
{
    class CalculoDeArea
    {

        public static double CalcularCuadrado(double lado)
        {
            double retorno = 0;
            if(lado>0)
            {
                retorno = lado * lado;
            }
            return retorno;
        }

        public static double CalcularTriangulo(double altura, double laBase)
        {
            double retorno = 0;
            
            if(altura>0 && laBase>0)
            {
                retorno = ((altura * laBase) / 2);

            }
            return retorno;
        }

        public static double CalcularCirculo (double diametro)
        {
            double retorno = 0;
            double radio = diametro / 2;
            if(diametro>0)
            {
                retorno = (Math.PI * (Math.Pow(radio, 2)));
            }

            return retorno;

        }

    }
}
