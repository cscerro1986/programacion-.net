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

        public override float CostoLlamada 
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

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.Append("\nCosto de la llamada: "+this.CalcularCosto());
            
            return sb.ToString();

        }

        public override bool Equals(object obj)
        {
            if (obj is Local)
                return true;

            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
