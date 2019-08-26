

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equipos_de_beisbol
{
    class Program
    {
        static void Main(string[] args)


        {

            List<Jugador> jugador = new List<Jugador>();

            equipo beisbol1 = new equipo("obregon", "juan");
            jugador.Add(beisbol1);
           
            Jugador jose = new Jugador("jose", "34");
            Jugador ana = new Jugador("ana", "23");
            Jugador mary = new Jugador("mary", "25");
            Jugador tana = new Jugador("tana", "26");
            Jugador lana = new Jugador("lana", "63");
            Jugador mara = new Jugador("mara", "27");
            Jugador juana = new Jugador("juana", "93");
            Jugador roberto = new Jugador("roberto", "23");
            Jugador lili = new Jugador("lili", "23");

            beisbol1.Jugadors.Add(jose);
            beisbol1.Jugadors.Add(ana);
            beisbol1.Jugadors.Add(mary);
            beisbol1.Jugadors.Add(tana);
            beisbol1.Jugadors.Add(lana);
            beisbol1.Jugadors.Add(mara);
            beisbol1.Jugadors.Add(juana);
            beisbol1.Jugadors.Add(roberto);
            beisbol1.Jugadors.Add(lili);


            foreach (Jugador jugador1 in jugador)
            {
                Console.WriteLine("equipo 1");

                Console.WriteLine("equipo1" + beisbol1.CiudadDeOrigen);
                Console.WriteLine("entrenador" + beisbol1.Entrenador);

                foreach (equipo jugador2 in beisbol1.Jugadores)
                {
                    Console.WriteLine("-" + jugador1.Nombre);
                    Console.WriteLine("-" + jugador1.Numero);
                    
                }


                

            }







        }
    }
}
