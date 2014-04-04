using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShiftAndAdd;

namespace ShiftAndAddTests
{
    [TestFixture]
    public class BinaryMultiplicationOfTwoNumbersTests
    {
        [Test]
        public void Multiply11Times14Success()
        {
            var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
            Assert.AreEqual(154, binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(11, 14));
        }

        [Test]
        public void Multiply256Times19Success()
        {
            var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
            Assert.AreEqual(4864, binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(256, 19));
        }

        [Test]
        public void Multiply102Times233Success()
        {
            var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
            Assert.AreEqual(23766, binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(102, 233));
        }

        [Test]
        public void Multiply1021Times2331Success()
        {
            var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
            Assert.AreEqual(2379951, binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(1021, 2331));
        }

        [Test]
        public void Multiply10216Times23312Success()
        {
            var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
            Assert.AreEqual(238155392, binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(10216, 23312));
        }

        //[Test]
        //public void Multiply102162Times233120Success()
        //{
        //    var binaryMultiplicationOfTwoNumbers = new BinaryMultiplicationOfTwoNumbers();
        //    Assert.AreEqual(23816005440, binaryMultiplicationOfTwoNumbers.MultiplyTheBinaryWay(102162, 233120));
        //}
    }
}
