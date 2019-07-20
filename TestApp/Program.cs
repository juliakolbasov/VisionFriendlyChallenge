using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] input = { (int) 12, (long) 10653, (byte) 12, (sbyte) -5,
                         16.3, "string" , (System.Int32)32,  new Tuple <int, string, string>(1, "Julia", "Test")};

            Console.WriteLine(IntAddition.getSum(input));
            Console.Read();
        }

       
    }
}
