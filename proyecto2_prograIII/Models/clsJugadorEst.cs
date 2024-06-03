using proyecto2_prograIII.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2_prograIII.Models
{
    public class clsJugadorEst: InterfaceComp
    {

        public string full_name { get; set; }
        public string age { get; set; }
        public string position { get; set; }
        public string nationality { get; set; }
        public string goals_overall { get; set; }
        public string assists_overall { get; set; }
        public string yellow_cards_overall { get; set; }
        public string red_cards_overall { get; set; }
        public string Current_Club { get; set; }


        public clsJugadorEst() { }
        public clsJugadorEst(string full_name, string age, string position,  string nationality, string goals_overall,  string assists_overall, string yellow_cards_overall, string red_cards_overall, string Current_club)
        {
            this.full_name = full_name;
            this.age = age;
            this.position = position;
            this.nationality = nationality;
            this.goals_overall = goals_overall;
            this.assists_overall = assists_overall;
            this.yellow_cards_overall = yellow_cards_overall;
            this.red_cards_overall= red_cards_overall;
            this.Current_Club = Current_club;
        }

        public clsJugadorEst(string full_name)
        {
            this.full_name = full_name;
        }

        public bool igualQue(object q)
        {
            clsJugadorEst j = (clsJugadorEst)q;
            if (this.full_name.CompareTo(j.full_name) == 0)
                return true;
            return false;

        }

        public override string ToString()
        {
            return $"{full_name} - {age} - {Current_Club} - {position} - {nationality} - {goals_overall}\r\n";
        }
    }
}
