using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] a = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter a[{0}] : ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
            foreach (int k in a)
                Console.WriteLine(k);*/
            Console.Write("Enter size : ");
            int x = int.Parse(Console.ReadLine());
            string[] names = new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.Write("Enter names[{0}] : ", i);
                names[i] = Console.ReadLine();
            }
             
                Console.WriteLine("Enter the name :  ");
                string nam = Console.ReadLine();

            int flag = 0;
            for  (int k = 0; k < x; k++)
            {
                if (names[k] == nam)
                {
                    flag = 1;
                    Console.WriteLine("Index of " + names[k] + " is" + k);
                    break;
                }
            }
            if(flag==0)
            
                    Console.WriteLine("No name exists");
                
            
            Console.ReadKey();
        }
        

        }

    }







