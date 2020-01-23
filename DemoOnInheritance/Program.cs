using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOnInheritance
{

    class Parent
    {
        internal int a;
        protected string b;

        public int A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }

        public void getValues(int x,string y)
        {
            this.A = x;
            this.B = y;
        }

        public void Display()
        {
            Console.WriteLine("a value : " + this.A + "  b value : " + this.B+"\n");
        }
    }

    class Child : Parent
    {
        public int c;

        public void calculate(int num)
        {
            c = this.a + num;
            Console.WriteLine("c value : " + c+"\n");

        }
    }

    class GrandChild:Child
    {
        int d;

        public void multiply(int num1)
        {
            this.d = this.c* num1;
            Console.WriteLine("d value : " + d);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            Child ch = new Child();
            p.getValues(12,"fdhg");
            p.Display();

            ch.getValues(48, "lsdjfk");
            ch.Display();
            ch.calculate(6);

            GrandChild g = new GrandChild();
            g.getValues(134, "fdalsdkf");
            g.Display();
            g.calculate(4);
            g.multiply(4);
            Console.ReadKey();
        }
    }
}


namespace DemoOnProtected
{
    class ExChild:DemoOnInheritance.Parent
    {
        public void ExDisplay()
        {
            Console.WriteLine("a value : " + this.A + "  b value : " + this.B + "\n");
        }
    }
}
