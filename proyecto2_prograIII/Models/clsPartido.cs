using proyecto2_prograIII.HashTable.LinkedListHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.Models
{
    public class clsPartido: InterfaceCompHash
    {
        public string date_GMT { get; set; }
        public string status { get; set; }
        public string home_team_name { get; set; }
        public string away_team_name { get; set; }
        public string referee { get; set; }
        public string home_team_goal_count { get; set; }
        public string away_team_goal_count { get; set; }
        public string total_goal_count { get; set; }
        public string stadium_name { get; set; }

        public clsPartido()
        {

        }

        public clsPartido(string date_GMT, string status, string home_team_name, string away_team_name, string referee, string home_team_goal_count, string away_team_goal_count  //, string total_goal_count
            , string stadium_nam)
        {
            this.date_GMT = date_GMT;
            this.status = status;
            this.home_team_name = home_team_name;
            this.away_team_name = away_team_name;
            this.referee = referee;
            this.home_team_goal_count = home_team_goal_count;
            this.away_team_goal_count = away_team_goal_count;
            this.total_goal_count = int.Parse(home_team_goal_count) + int.Parse(away_team_goal_count)+"";
            this.stadium_name = stadium_nam;
        }

        public clsPartido(string date_GMT, string stadium_name)
        {
            this.date_GMT = date_GMT;
            this.stadium_name = stadium_name;
        }

        public clsPartido(string date_GMT, string home_team_name, string away_team_name)
        {
            this.date_GMT = date_GMT;
            this.home_team_name=home_team_name;
            this.away_team_name = away_team_name;
        }

        //Compara un string concatenado de equipo local, visitante y fecha del partido
        public bool igualQue(object q)
        {
            clsPartido at = (clsPartido)((clsNodoLKHash)q).dato;
            string comparar = at.home_team_name + at.away_team_name + at.date_GMT;
            string compararThis = this.home_team_name + this.away_team_name + this.date_GMT;

            if (compararThis.CompareTo(comparar) == 0)
                return true;

            return false;
        }
        //Compara un string concatenado de equipo local, visitante y fecha del partido
        public bool igualQueEliminar(object q)
        {
            clsPartido at = (clsPartido) q;
            string comparar = at.home_team_name + at.away_team_name + at.date_GMT;
            string compararThis = this.home_team_name + this.away_team_name + this.date_GMT;
            if (compararThis.CompareTo(comparar) == 0)
                return true;

            return false;
        }

        //Ordenar por equipo local y visitante y fecha: Concatenacion de los 3 campos
        /// <summary>
        /// Home team - Away team - date
        /// sin espaciosentre si, solo concatenar
        /// </summary>
        /// <returns></returns>
        public long convertirASCII()
        {            
            long asciiSum = 0;
            string compararThis = this.home_team_name + this.away_team_name + this.date_GMT;
            foreach (char c in compararThis)
            {
                asciiSum += (int)c; // Sumar el valor ASCII del carácter
            }
            return asciiSum;
        }

        public override string ToString()
        {
            return $"{date_GMT} - {home_team_name} - {away_team_name} - {stadium_name} \r\n";
        }
    }
}
