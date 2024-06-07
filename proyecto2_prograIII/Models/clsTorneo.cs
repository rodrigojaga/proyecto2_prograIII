using proyecto2_prograIII.AVL;
using proyecto2_prograIII.HashTable.LinkedListHash;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.Models
{
    public class clsTorneo: interfaceComparador, InterfaceCompHash
    {
        
        public clsPartido partido { get; set; }
        public clsEquipos equipo1 { get; set; }
        public clsEquipos equipo2 { get; set; }
        public clsJugadorEst[] jugadoresEquipoHome {  get; set; }

        public clsJugadorEst[] jugadoresEquipoAway { get; set; }

        public clsTorneo()
        {

        }

        public clsTorneo(clsPartido partido, clsEquipos equipo1, clsEquipos equipo2, clsJugadorEst[] jugadoresEquipoHome, clsJugadorEst[] jugadoresEquipoAway)
        {
            this.equipo1 = equipo1;
            this.equipo2 = equipo2;
            this.partido = partido;
            this.jugadoresEquipoHome = jugadoresEquipoHome;
            this.jugadoresEquipoAway = jugadoresEquipoAway;
        }

        public clsTorneo(clsPartido partido)
        {
            this.partido = partido;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("JUgadores casa: ");
            if (jugadoresEquipoHome != null)
            {
                foreach (clsJugadorEst jugador in jugadoresEquipoHome)
                {
                    sb.Append(jugador.ToString());
                }
            }

            sb.Append("JUgadores Visitante: ");
            if (jugadoresEquipoAway != null)
            {
                foreach (clsJugadorEst jugador in jugadoresEquipoAway)
                {
                    sb.Append(jugador.ToString());
                }
            }
            return $"{partido.ToString()} - " +
                $"Equipo home: {equipo1.ToString()}" +
                $"- Equipo away {equipo2.ToString()}" +
                $"{sb.ToString()}";
        }


        public bool igualQue(object q)
        {
            //string[] partes = this.partido.date_GMT.Split('-');
            //string[] partesObj = ((clsTorneo)q).partido.date_GMT.Split('-');
            //if (partes[1].CompareTo(partesObj[1]) == 0)
            return (this.partido.date_GMT+ this.partido.stadium_name).CompareTo(((clsTorneo)q).partido.date_GMT + ((clsTorneo)q).partido.stadium_name) == 0;
            //return false;
        }

        public bool menorQue(object q)
        {
            string[] partes = this.partido.date_GMT.Split('-');
            string[] partesObj = ((clsTorneo)q).partido.date_GMT.Split('-');
            //if (partes[1].CompareTo(partesObj[1]) == 0)
            return (this.partido.date_GMT + this.partido.stadium_name).CompareTo(((clsTorneo)q).partido.date_GMT + ((clsTorneo)q).partido.stadium_name) == -1;
        }

        public bool mayorQue(object q)
        {
            string[] partes = this.partido.date_GMT.Split('-');
            string[] partesObj = ((clsTorneo)q).partido.date_GMT.Split('-');
            //if (partes[1].CompareTo(partesObj[1]) == 0)
            return (this.partido.date_GMT + this.partido.stadium_name).CompareTo(((clsTorneo)q).partido.date_GMT + ((clsTorneo)q).partido.stadium_name) == 1;
        }

        public bool igualQueHash(object q)
        {
            clsArbolAVL at = (clsArbolAVL)((clsNodoLKHash)q).dato;
            clsTorneo qa = (clsTorneo)at.raizArbol().valorNodo();
            string comparar = qa.partido.home_team_name + qa.partido.away_team_name + qa.partido.date_GMT+qa.partido.stadium_name;
            string compararThis = this.partido.home_team_name + this.partido.away_team_name + this.partido.date_GMT + this.partido.stadium_name;

            if (compararThis.CompareTo(comparar) == 0)
                return true;

            return false;
        }

        public bool igualQueEliminarHash(object q)
        {
            clsTorneo at = (clsTorneo)q;
            string comparar = at.partido.home_team_name + at.partido.away_team_name + at.partido.date_GMT + at.partido.stadium_name;
            string compararThis = this.partido.home_team_name + this.partido.away_team_name + this.partido.date_GMT + this.partido.stadium_name;
            if (compararThis.CompareTo(comparar) == 0)
                return true;

            return false;
        }

        public long convertirASCII()
        {
            long asciiSum = 0;
            string compararThis = this.partido.home_team_name + this.partido.away_team_name + this.partido.date_GMT + this.partido.stadium_name;
            foreach (char c in compararThis)
            {
                asciiSum += (int)c; // Sumar el valor ASCII del carácter
            }
            return asciiSum;
        }
    }
}
