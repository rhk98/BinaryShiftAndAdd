using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftAndAdd
{
    public class BinaryMultiplicationBy2
    {
        public int DoubleMeTheBinaryWay(int number)
        {
            var x = number << 1;
            const int y = 0;
            return x | y;
        }
    }
}
