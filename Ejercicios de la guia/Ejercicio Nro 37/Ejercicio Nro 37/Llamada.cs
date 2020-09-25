using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Llamada
    {

        public enum TipoLlamada { Local, Provincial, Todas}

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public float Duracion 
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino 
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOringe
        {
            get
            {
                return this.nroOrigen;
            }
        }


        #region Metodos

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Duracion: " + this.Duracion);
            sb.Append("\nNumero de Origen: " + this.NroOringe);
            sb.Append("\nNumero de Destino: " + this.nroDestino);

            return sb.ToString();

        }


        /// <summary>
        /// Compara dos llamadas y retorna 1 si la primer llamda es mas larga.
        /// retornara 2 si la segunda llamada es mas larga.
        /// en caso de ser iguales retornara 0.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarLlamadaPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;

            if (llamada1.Duracion < llamada2.Duracion)
                return -1;


            return 0;

        }
        #endregion Metodos


    }
}
