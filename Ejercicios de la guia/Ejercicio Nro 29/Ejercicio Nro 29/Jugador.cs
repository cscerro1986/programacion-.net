using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int golesTotales;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioDeGoles = 0;
            this.golesTotales = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.golesTotales = totalGoles;
            this.partidosJugados = totalPartidos;

        }

        //operadores

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public float GetPromedioGoles()
        {
            if (this.partidosJugados > 0)
                return (float)(this.golesTotales / this.partidosJugados);

            return 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0} " + this.nombre);
            sb.AppendFormat("\nDNI: {0} " + this.dni);
            sb.AppendFormat("\nPartidos jugados: {0} " + this.partidosJugados);
            sb.AppendFormat("\nGoles: {0} " + this.golesTotales);
            sb.AppendFormat("\nPromedio de goles : {0} " + this.promedioDeGoles);

            return sb.ToString();
        }



    }


}
    