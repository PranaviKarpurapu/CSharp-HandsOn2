using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Program
    {
        public static string Greet()
        {
            return "welcome to the world of c#";

        }
        public static string Display(string name)
        {
            return "Hi" + name + "Welcome to the world of c#";
        }
        public static void Num(int x, int y)
        {
            int i;
            for (i = x; i <= y; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static string EvenOdd(int n)
        {
            if (n % 2 == 0)
                return " even";
            else
                return " odd";
        }
        public static double Celusis(double f)
        {


            return ((f - 32) * 5) / 9;
        }
        public static void Shop()

        {
            int n;
            do
            {


                Console.WriteLine("enter the product number and quantity");
                int op = int.Parse(Console.ReadLine());
                int qunt = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine(qunt * 22.5);
                        break;
                    case 2:
                        Console.WriteLine(qunt * 44.50);
                        break;
                    case 3:
                        Console.WriteLine(qunt * 9.98);
                        break;

                }
                Console.WriteLine("if you want to purchase more press 1");
                n = int.Parse(Console.ReadLine());
            } while (n == 1);
            if (n == 0)
                Environment.Exit(0);
        }
        public static void Series()
        {
            for (int i = 0; i <= 25; i++)
            {
                Console.Write(i * i + " ");
            }
        }
        public static int fact(int g)
        {
            int fact = 1;
            for (int i = 1; i <= g; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static void fib()
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine(a);
            Console.WriteLine(b);



            do
            {
                c = a + b;



                Console.WriteLine(c);


                int temp = a;
                a = b;
                b = c;

            } while (c <= 40);
        }
        public static void Mul(int n)
        {
            int i;
            for (i = 1; i <= 20; i++)
            {
                Console.WriteLine(n + "*" + i + "=" + n * i);
            }
        }

        public static void div()
        {
            for(int i=200;i<=300;i++)
            {
                if(i%7==0)
                {
                    Console.WriteLine(i + "  is divisible by 7");
                }
            }
        }

        public static void large(int p,int q,int r)
        {
            if (p > q && p > r)
            {
                Console.WriteLine(p + " is largest");
            }
            else if (q > r)
                Console.WriteLine(q + " is largest");
            else
                Console.WriteLine(r + " is largest");
            }
            public static void small()
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int smallest = 0;
            for(int i=0;i<5;i++)
            {
                for(int j=i+1;j<5;j++)
                {
                    if (a[i] < a[j])

                    smallest = a[i];
                    a[i] = a[j];
                    a[j] = smallest;
                }
            }
            Console.WriteLine("Smallest of 5 Elements is : " + a[0]);
        }
        

        public static void marks()
        {
            Console.WriteLine();
        }
            static void Main(string[] args)
        {
            /*
             Console.WriteLine(Greet());
             Console.WriteLine("enter your name");
            
             string s = Console.ReadLine();
            Console.WriteLine( Display(s));
            
             Console.WriteLine("enter any two numbers");
             int x = int.Parse(Console.ReadLine());
             int y= int.Parse(Console.ReadLine());

             Num(x, y);

             Console.WriteLine("enter any  number to find even or odd");

             int n= int.Parse(Console.ReadLine());

             Console.WriteLine(n +"is"+EvenOdd(n));

             Console.WriteLine("enter temperature in fahrenheit");
             double f = double.Parse(Console.ReadLine());
             Console.WriteLine(Celusis(f));

            Console.WriteLine("productnum \t  productprice");
            Console.WriteLine("product 1 \t 22.5");
            Console.WriteLine("product 2 \t 44.50");
            Console.WriteLine("product 3 \t 9.98");

            Shop();


            Series();
            Console.WriteLine("enter a number to find factorial");
            int g= int.Parse(Console.ReadLine());
          Console.WriteLine(  fact(g));
            Console.WriteLine("fibonaci series");
            fib();
            
            Console.WriteLine("enter number for multiplication table");

            int k= int.Parse(Console.ReadLine());
            Mul(k);
            
            div();
            
            Console.WriteLine("enter  numbers to find the largest between them :");
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine()); 
            int r = int.Parse(Console.ReadLine());
            large(p, q, r);
           
            Console.WriteLine("enter  numbers to find the smallest between them :");
            
            small();
           
            */

            //
            
            marks();






            Console.ReadKey();
        }
    }
    }
