using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Nro_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidadDeJugadores, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo equ1, Jugador j1)
        {
            bool retorno = false;

            if(equ1.cantidadDeJugadores<equ1.jugadores.Count)
            {
                foreach (Jugador item in equ1.jugadores)
                {
                    if (item == j1)
                        return false;
                }
                equ1.jugadores.Add(j1);
                retorno = true;
            }
            return retorno;

        }






    }
}
