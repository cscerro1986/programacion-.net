using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
   public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto Vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.Vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());


            //this.Vertice2 = new Punto(Math.Abs(this.vertice3.GetX()), Math.Abs(this.vertice1.GetY()));
            //this.vertice4= new Punto(Math.Abs(this.vertice1.GetX()), Math.Abs(this.vertice3.GetY()));
        }

        public float Perimetro()
        {

            return ((CalcularDistanciaEntrePuntos(this.vertice1, this.Vertice2)) * 2 + (CalcularDistanciaEntrePuntos(this.vertice1, this.vertice4)*2));
        }

        public float Area()
        {
            return CalcularDistanciaEntrePuntos(this.vertice1, this.Vertice2) * CalcularDistanciaEntrePuntos(this.Vertice2, this.vertice3);
        }

        public static float CalcularDistanciaEntrePuntos(Punto vertice1, Punto vertice2)
        {
            double distancia = Math.Sqrt(Math.Pow((vertice1.GetX() - vertice2.GetX()), 2) + Math.Pow((vertice1.GetY() - vertice2.GetY()), 2));

            return (float)distancia;
        }


    }
}
