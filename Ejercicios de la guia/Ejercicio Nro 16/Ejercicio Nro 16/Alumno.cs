using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_Nro_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;    
        private string apellido;
        private int legajo;
        private string nombre;

        public Alumno(string apellido, int legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public void CalcularFinal()
        {
            if(this.nota1>=4&&this.nota2>=4)
            {
                Random rm = new Random();
                this.notaFinal = rm.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }

        

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*******************************");
            sb.AppendLine("Nombre: "+this.nombre);
            sb.AppendLine("Apelido: "+this.apellido);
            sb.AppendLine("Nota primero parcial" + this.nota1);
            sb.AppendLine("Nota segundo parcial" + this.nota2);
            sb.AppendLine("Nota Final" + this.notaFinal);

            return sb.ToString();
        }
    }
}
