using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversions
{
    class ParseDemo
    {
        static void Main(string[] args)
        {
            sbyte sp = sbyte.Parse("123");
            float fp = float.Parse("123.456");
            decimal dp = decimal.Parse("123.45");
            bool bp = bool.Parse("true");
            Console.WriteLine("sp:{0}\nfp:{1}\ndp:{2}\nbp:{3}", sp, dp, dp, bp);
            Console.ReadKey();
        }
    }
}
