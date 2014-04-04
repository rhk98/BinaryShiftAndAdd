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
    public class BinaryMultiplicationBy2Tests
    {
        [Test]
        public void DoubleMeTheBinaryWaySuccessFor17()
        {
            var binaryMultiplicationBy2 = new BinaryMultiplicationBy2();

            Assert.AreEqual(34, binaryMultiplicationBy2.DoubleMeTheBinaryWay(17) );

        }

        [Test]
        public void DoubleMeTheBinaryWaySuccessFor123()
        {
            var binaryMultiplicationBy2 = new BinaryMultiplicationBy2();

            Assert.AreEqual(246, binaryMultiplicationBy2.DoubleMeTheBinaryWay(123));
        }

        [Test]
        public void DoubleMeTheBinaryWaySuccessFor10945()
        {
            var binaryMultiplicationBy2 = new BinaryMultiplicationBy2();

            Assert.AreEqual(21890, binaryMultiplicationBy2.DoubleMeTheBinaryWay(10945));

        }
    }
}
