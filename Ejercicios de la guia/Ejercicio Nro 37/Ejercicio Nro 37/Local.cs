using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Local: Llamada
    {
        protected float costo;


        public Local(Llamada llamada,float costo):this(llamada.NroOringe,llamada.Duracion,llamada.NroDestino,costo)
        {
            
        }

        public Local(string origen, float duracion,  string destino,  float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        public float CostoLlamada 
        {
            get
            {
                return this.CalcularCosto();
            } 
        }

        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("\nCosto de la llamada: "+this.CalcularCosto());
            
            return sb.ToString();

        }




    }
}
