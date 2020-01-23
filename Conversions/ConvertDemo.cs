using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class ConvertDemo
    {
        static void Main(string[] args)
        {
            /*bool ii = Convert.ToBoolean("true");
            Console.WriteLine(ii);
             ii = Convert.ToBoolean("false");
            Console.WriteLine(ii);
            Console.ReadKey();*/
            string s = Convert.ToString(true);
            Console.WriteLine(s);
            s = Convert.ToString(1.23);
            Console.WriteLine(s);
            s = Convert.ToString('A');
            Console.WriteLine(s);
            Console.WriteLine("Null:"+Convert.ToString(null));
            int i = Convert.ToInt32(67);
            short sh = Convert.ToInt16(78);
            long lg = Convert.ToInt64(90);
            Console.WriteLine("int :"+i);
            Console.WriteLine("short:"+sh);
            Console.WriteLine("long :"+lg);
            Console.ReadKey();

        }
    }
}
