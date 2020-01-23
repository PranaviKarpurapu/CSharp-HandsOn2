using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class ObjectDemo
    {
        static void Main()
        {
            //boxing
            int i = 19;
            double d = 67.7890;
            float f = 56.34f;
            char ch = 'g';
            object o1 = i;
            object o2 = d;
            object o3 = f;
            object o4 = ch;
            Console.WriteLine("o1 is : "+o1);
            Console.WriteLine("o2 is :" +o2);
            Console.WriteLine("o3 is :" +o3);
            Console.WriteLine("o4 is :" +o4);
            //unboxing
            object ob1 = 122;
            int k = (int)ob1;
            object ob2 = 122.5689;
            double k1 = (double)ob2;
            object ob3 = 'g';
            char k2 = (char)ob3;
            object ob4 = "giri";
            string k3 = (string)ob4;
            Console.WriteLine("int is:"+k);
            Console.WriteLine("double is:"+k1);
            Console.WriteLine("char is: "+k2);
            Console.WriteLine("string is:"+k3);
            //convert into string
            k3 = i.ToString();
            Console.WriteLine("k3:"+k3);
            k3 = k1.ToString();
            Console.WriteLine("k3:"+k3);
            Console.ReadKey();
            //Console.WriteLine(typeof(ob2));



        }


    }
}
