using proyecto2_prograIII.AVL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.Models
{
    public class clsEquipos:interfaceComparador
    {

        public string team_name { get; set; }
        public string common_name { get; set; }
        public string country { get; set; }
        public string matches_played { get; set; }
        public string wins { get; set; }
        public string draws { get; set; }
        public string losse { get; set; }


        public clsEquipos() { } 
        
        public clsEquipos(string team_name, string  common_name, string country, string matches_played, string wins, string draws, string losse)
        {
            this.team_name = team_name;
            this.common_name = common_name;
            this.country = country;
            this.matches_played = matches_played;
            this.wins = wins;
            this.draws = draws;
            this.losse = losse;
        }

        public clsEquipos(string common_name)
        {
            this.common_name=common_name;
        }

        public bool igualQue(object q)
        {
            clsEquipos e = (clsEquipos)q;   
            return this.common_name.CompareTo(e.common_name) == 0;
            
        }

        public bool menorQue(object q)
        {
            clsEquipos e = (clsEquipos)q;
            return this.common_name.CompareTo(e.common_name) == -1;
            
        }

        public bool mayorQue(object q)
        {
            clsEquipos e = (clsEquipos)q;
            return this.common_name.CompareTo(e.common_name) == 1;            
        }

        public override string ToString()
        {
            return $"{common_name} - {wins} - {losse} - {country}\r\n";
        }

    }
}
