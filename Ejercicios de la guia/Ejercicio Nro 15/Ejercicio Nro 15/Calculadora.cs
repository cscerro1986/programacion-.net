using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_15
{
    public class Calculadora
    {
        public static double Calcular(double numero1, double numero2, char operador)
        {
            double retorno = 0;

            switch(operador)
            {
                case '+':
                    retorno = numero1 + numero2;
                    break;
                case '-':
                    retorno = numero1 - numero2;
                    break;
                case '*':
                    retorno = numero1 * numero2;
                    break;
                case '/':
                    retorno = numero1 / numero2;
                    break;
            }

            return retorno;

        }

        public static bool Validar(double numero)
        {
            bool retorno = false;

            if(numero!=0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
