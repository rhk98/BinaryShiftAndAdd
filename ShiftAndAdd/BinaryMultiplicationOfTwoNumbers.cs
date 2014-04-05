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
            var powersOf2 = GetPowersOf2(multiplicand, multiplier);
            return ShiftAndAdd(powersOf2);
        }

        private IList<int> GetPowersOf2(int multiplicand, int multiplier)
        {
            var multiplierInBits = new BitArray(new int[] { multiplier });
            return
                (from bool multiplierInBit in multiplierInBits
                 select MultiplyBit(multiplicand, Convert.ToInt32(multiplierInBit))).ToList();
        }

        private int MultiplyBit(int multiplicand, int bit)
        {
            return bit == 0 ? 0 : multiplicand;
        }

        private int ShiftAndAdd(IList<int> powersOf2)
        {
            var multiplyResult = 0;
            for (var index = 0; index < powersOf2.Count; index++)
            {
                multiplyResult = multiplyResult + (powersOf2[index] << index);
            }
            return multiplyResult;
        }
    }
}