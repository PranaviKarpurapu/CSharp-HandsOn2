using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOnInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Menu\n1.Cricket Player Details\n2.Hockey Player Details  ");

            Console.WriteLine("  Enter your choice : ");
            int ch = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name :");
            string cl = Console.ReadLine();
            Console.WriteLine("Enter Team Name :");
            string tl = Console.ReadLine();
            Console.WriteLine("Enter No.of Matches played :");
            int m = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    
                    Console.WriteLine("Enter total runs scored :");
                    int r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter total no.of Wickets taken :");
                    int w = int.Parse(Console.ReadLine());
                    CricketPlayer cp = new CricketPlayer(cl,tl,m,r,w);
                    cp.Display();
                    break;
            

               case 2:
                    Console.WriteLine("Enter total Goals scored :");
                    int g = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter total no.of Positions taken :");
                    int p = int.Parse(Console.ReadLine());
                    HockeyPlayer hp = new HockeyPlayer(cl, tl, m, g, p);
                    hp.Display();
                    break;

                default :
                    Console.WriteLine("Invalid Option");
                    break;
            }
            Console.ReadKey();

        }
    }
}
