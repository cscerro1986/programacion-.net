using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_37
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        //public float GananciasPorLocal
        //{

        //    get
        //    {
        //        float numero = 0;
        //        foreach (Llamada item in listaLlamadas)
        //        {
        //            if (item is Local)
        //            {
        //                numero = numero + ((Local)item).CostoLlamada;
        //            }
        //        }

        //        return numero;
        //    }
        //}

        //public float GananciasPorProvincial
        //{
        //    get
        //    {

        //        float numero = 0;
        //        foreach (Llamada item in listaLlamadas)
        //        {
        //            if (item is Provincial)
        //            {
        //                numero = numero + ((Provincial)item).CostoLlamada;
        //            }
        //        }

        //        return numero;


        //    }
        //}


        //public float GananciasPorTotal
        //{
        //    get
        //    {

        //        float numero = 0;
        //        foreach (Llamada item in listaLlamadas)
        //        {
        //            if (item is Local)
        //            {
        //                numero = numero + ((Local)item).CostoLlamada;
        //            }

        //            if (item is Provincial)
        //            {
        //                numero = numero + ((Provincial)item).CostoLlamada;
        //            }
        //        }

        //        return numero;

        //    }
        //}


        public float GananciasPorLocal
        {

            get
            {
               return this.CalcularGanancias(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Provincial);
            }
        }


        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancias(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLlamadas;
            }
        }


        //private float CalcularGanancia(Llamada.TipoLlamada tipo)
        //{
        //    if (tipo == Llamada.TipoLlamada.Local)
        //        return this.GananciasPorLocal;

        //    if (tipo == Llamada.TipoLlamada.Provincial)
        //        return this.GananciasPorProvincial;

        //    if (tipo == Llamada.TipoLlamada.Todas)
        //        return this.GananciasPorTotal;

        //    return 0;
        //}


        private float CalcularGanancias(Llamada.TipoLlamada tipo)
        {

            float totalLocal = 0;
            float totalProvincial = 0;
            float retorno = 0;


            foreach (Llamada item in this.listaLlamadas)
            {
                if(item is Local)
                    totalLocal=totalLocal+ ((Local)item).CostoLlamada;

                if(item is Provincial)
                    totalProvincial= ((Provincial)item).CostoLlamada;

            }

            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno= totalLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = totalProvincial;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = totalProvincial + totalLocal;
                    break;

            }

            return retorno;

        }



        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\n**************************************");
            sb.AppendLine("Razon social: " + this.razonSocial);
            sb.AppendLine("Ganancia Total: " + this.GananciasPorTotal);
            sb.AppendLine("Ganancia Local: " + this.GananciasPorLocal);
            sb.AppendLine("Ganancia Provincial: " + this.GananciasPorProvincial);
            sb.AppendLine("**************************************");

            sb.AppendLine("\n**********LISTADO DE LLAMADAS********************");
            foreach (Llamada item in this.Llamadas)
            {
                sb.AppendLine("\n");
                if(item is Local)
                {
                    sb.AppendLine(((Local)item).Mostrar());
                }

                if (item is Provincial)
                {
                    sb.AppendLine(((Provincial)item).Mostrar());
                }


            }
           

            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {
            this.listaLlamadas.Sort(Llamada.OrdenarLlamadaPorDuracion);
        }

        
    }
}
