using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipos_de_beisbol
{
    class equipo
    {
        public string Nombre { get; set; }
        public string CiudadDeOrigen { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public List<Jugador> Jugadors { get;  set; }

        public equipo ()
        {
            Nombre = "sin nombre";
            CiudadDeOrigen = "vacio";
            Entrenador = "sin entrenador";
            Jugadores = "sin jugadores";

        }

        public equipo(string ciudaddeorigen, string entrenador)
        {
            CiudadDeOrigen = ciudaddeorigen;
            Entrenador = entrenador;
            Jugadors = new List<Jugador>();
        }

    }
}
