using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAndAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
                var result = binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]));
                Console.WriteLine("The result the binary way is {0}", result);
            }
            else
            {
                Console.WriteLine("I will only accept 2 integers today...");
            }
        }
    }
}
