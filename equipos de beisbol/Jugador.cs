using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipos_de_beisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }

        public Jugador ()
        {
            Nombre = "sin nombre";
            Numero = "sin numero";
        }

        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
