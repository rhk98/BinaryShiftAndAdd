using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ShiftAndAdd
{
    public class BinaryMultiplicationOfTwoNumbers
    {
        public int MultiplyTheBinaryWay(int multiplicand, int multiplier)
        {
            var multiplierInBits = new BitArray(new int[] {multiplier});

            IList<int> powersOf2 =
                (from bool multiplierInBit in multiplierInBits
                    select MultiplyBit(multiplicand, Convert.ToInt32(multiplierInBit))).ToList();

            return ShiftAndAdd(powersOf2);
        }

        private int MultiplyBit(int multiplicand, int bit)
        {
            return bit == 0 ? 0 : multiplicand;
        }

        private int ShiftAndAdd(IList<int> powersOf2)
        {
            var multiplyResult = powersOf2[0];
            for(var xx = 1; xx < powersOf2.Count; xx++)
            {
                multiplyResult = multiplyResult + (powersOf2[xx] << xx);
            }
            return multiplyResult;
        }
    }
}
