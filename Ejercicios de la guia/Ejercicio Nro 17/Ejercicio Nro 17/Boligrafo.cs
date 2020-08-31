using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;

        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta( short tinta)
        {
            int tintaActual = this.tinta;
            //cuando cargo la tinta... tinta es >0
            if(tinta>0)
            {            
                if(this.tinta+tinta<=cantidadTintaMaxima)
                {
                    tintaActual = tintaActual + tinta;
                    this.tinta = (short)tintaActual;
                }
                else
                {
                    this.tinta = cantidadTintaMaxima;
                }
            }
            else
            //cuando gasto la tinta. tinta es < 0
            {
                if(tintaActual>tinta)
                {
                    this.tinta = (short)(tintaActual - tinta);
                }
                else
                {
                    this.tinta = 0;
                }

            }

        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            string dibujito = "";

            this.SetTinta(tinta);
            if(this.tinta==0)
            {

            }
            else
            {                
                retorno = true;
                for(short i=0;i<gasto;i++)
                {
                    dibujito = dibujito + "*";
                }
            }

            dibujo = dibujito;
            return retorno;
        }



    }
}
