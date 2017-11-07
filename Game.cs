using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//i added or modified this file during step 7.

//step 10 master branch edit.


namespace GameLibLab2
{
    public class Game
    {
        public string Team1 { get; set; }
        public int Team1score { get; set; }
        public string Team2 { get; set; }
        public int Team2score { get; set; }

        public Game() { } //default constructor, required by serialization.
        public Game( string Team1, string Team2, int Team1score, int Team2score)
        {
            this.Team1 = Team1;
            this.Team1score = Team1score;
            this.Team2 = Team2;
            this.Team2score = Team2score;
        }

        public override string ToString()
        {
            return Team1 + " (" + Team1score + ") - " + Team2 + " (" + Team2score + ") ";
        }

    }
}
