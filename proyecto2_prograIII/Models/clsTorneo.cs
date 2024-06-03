using proyecto2_prograIII.AVL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.Models
{
    public class clsTorneo:interfaceComparador
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

        public clsTorneo()
        {

        }

        public clsTorneo(string date_GMT, string status, string home_team_name, string away_team_name, string referee, string home_team_goal_count, string away_team_goal_count, string total_goal_count, string stadium_nam)
        {
            this.date_GMT = date_GMT;
            this.status = status;
            this.home_team_name = home_team_name;
            this.away_team_name = away_team_name;
            this.referee = referee;
            this.home_team_goal_count = home_team_goal_count;
            this.away_team_goal_count = away_team_goal_count;
            this.total_goal_count = total_goal_count;
            this.stadium_name = stadium_nam;
        }

        public clsTorneo(string date_GMT, string stadium_name)
        {
            this.date_GMT = date_GMT;
            this.stadium_name = stadium_name;
        }

        public bool igualQue(object q)
        {
            clsTorneo a = (clsTorneo)q;
            return this.date_GMT.CompareTo(a.date_GMT) == 0 &&
                this.stadium_name.CompareTo(a.stadium_name) == 0;
        }

        public bool menorQue(object q)
        {
            clsTorneo a = (clsTorneo)q;
            return this.date_GMT.CompareTo(a.date_GMT) == 0 &&
                this.stadium_name.CompareTo(a.stadium_name) == 0;
        }

        public bool mayorQue(object q)
        {
            clsTorneo a = (clsTorneo)q;
            return this.date_GMT.CompareTo(a.date_GMT) == 0 &&
                this.stadium_name.CompareTo(a.stadium_name) == 0;
        }
    }
}
