using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
     public abstract class Player
    {
        protected string name;
        protected string tName;
        protected int no_of_matches;

        public Player(string name, string tName, int no_of_matches)
        {
            this.name = name;
            this.tName = tName;
            this.no_of_matches = no_of_matches;
            Console.WriteLine("\nParameterized Player Constructor");

        }

        public abstract void Display();
    }


    class CricketPlayer : Player
    {
        private int totalRuns;
        private int noOfWickets;

        public CricketPlayer(string name, string tName, int no_of_matches,int totalRuns, int noOfWickets):base(name, tName, no_of_matches)
        {
            this.totalRuns = totalRuns;
            this.noOfWickets = noOfWickets;
            Console.WriteLine("\n\nParameterized CricketPlayer Constructor");
        }

        public override void Display()
        {
            Console.WriteLine("\nPlayer Details :");
            Console.WriteLine("Name : "+this.name+"\nTeam Name : "+this.tName+"\nNo.of Matches : "+this.no_of_matches+"\nTotal Runs : " + this.totalRuns + "\nNo.of Wickets : " + this.noOfWickets);
        }
    }

    class HockeyPlayer : Player
    {
        private int totalGoals;
        private int position;

        public HockeyPlayer(string name, string tName, int no_of_matches,int totalGoals, int position) : base(name, tName, no_of_matches)
        {
            this.totalGoals = totalGoals;
            this.position = position;
            Console.WriteLine("\n\nParameterized HockeyPlayer Constructor");
        }

        public override void Display()
        {
            Console.WriteLine("\nPlayer Details :");
            Console.WriteLine("Name : " + this.name + "\nTeam Name : " + this.tName + "\nNo.of Matches : " + this.no_of_matches + "\nTotal Goals : " + this.totalGoals + "\nPosition : " + this.position);
        }
    }


}
