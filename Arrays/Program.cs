using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];
            i[0] = 1;
            i[1] = 2;
            i[3] = 4;
            i[4] = 5;
            foreach (int a in i)
            {
                Console.WriteLine(a);
            }
        }


        class Demo
        {
            static void Main()
            {
                int[] b = new int[5] { 1, 6, 7, 8, 9 };
                foreach (int x in b)
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine(x);

                    }
                
               }
                Console.ReadKey();
            }
          
        }
        
    }
}
