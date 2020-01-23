using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            long l1 = 45675675678;
            int i1 = (int)l1;
            float f1 = 12.5467f;
            int i2 = (int)f1;
            float b1 = 1.243f;
            int b2 = 34;
            float b3 = b1 + b2;
            long lx = 134565;
            double dx = 345.7809789;
            double res = lx + dx;
            Console.WriteLine("Double:" + res);
            Console.WriteLine("float:" + b3);
            Console.WriteLine("int:" + i1);
            Console.WriteLine("int :" + i2);
            Console.ReadKey();
        }
    }
}

