using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    namespace TestDifferenceOfSquares { 
        [TestClass]
        public class CalculateSquareOfSum
        {
            [TestMethod]
            public void SquareOfZero()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSquareOfSum(0),0);
            }

            [TestMethod]
            public void SqaureOfOne()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSquareOfSum(1),1);
            }

            [TestMethod]
            public void SqaureOfSumToTwo()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSquareOfSum(2), 9);
            }
        }
    }
}
