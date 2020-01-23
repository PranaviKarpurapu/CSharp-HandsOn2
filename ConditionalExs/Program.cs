using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalExs
{
    class Program
    {
     public static string EvenOrOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        public static int Maximum(int i,int j,int k)
        {
            if (i > j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result(double m1, double m2, double m3, double m4, double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg >= 70)
                return "Distinction with "+avg+"%";
            else if (avg >= 60 && avg < 70)
                return "First Class with " + avg + "%";
            else if (avg >= 50 && avg < 60)
                return "Second Class with " + avg + "%";
            else
                return "FAIL with " + avg + "%";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a num");
            int i = int.Parse(Console.ReadLine());
            string res = EvenOrOdd(i);
            Console.WriteLine("Num is :"+res);
            Console.WriteLine("\nMaximum:"+Maximum(122, 134, 6));
            Console.WriteLine("\nResult : "+Result(85.67, 54.56, 86.34, 78.89, 98.23));
            Console.WriteLine(i.GetType());
            Console.ReadKey();
        }
    }
}



