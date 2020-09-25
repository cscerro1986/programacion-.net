using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3}

        private Franja franjaHoraria;


        #region CONSTRUCTORES

        public Provincial(string origen, Franja franjaHoraria, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = franjaHoraria;
        }

        public Provincial(Franja franjaHoraria, Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOringe)
        {
            this.franjaHoraria = franjaHoraria;
        }

        #endregion CONSTRUCTORES

        public float CostoLlamada 
        {
            get
            {
                return this.CalcularCosto();
            }
        }


        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("\nFranja horaria: "+this.franjaHoraria.ToString());
            sb.Append("\nCosto de llamada: "+this.CostoLlamada);
            
            return sb.ToString();

        }

        private float CalcularCosto()
        {
            float retorno = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno= (float)(this.Duracion * 0.99);
                    break;

                case Franja.Franja_2:
                    retorno = (float)(this.Duracion * 1.25);
                    break;                    

                case Franja.Franja_3:
                    retorno = (float)(this.Duracion * 0.66);
                    break;

            }

            return retorno;
        }
    }
}
