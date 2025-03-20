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

            [TestMethod]
            public void NegativeMaxIsPos()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSquareOfSum(1), 1);
            }

            [TestMethod]
            public void SquareOfSumLargeMax()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSquareOfSum(10), 3025);
            }
        }

        [TestClass]
        public class CalculateSumOfSquares
        {
            [TestMethod]
            public void CanCall()
            {
                DifferenceOfSquares.CalculateSumOfSquares(0);
            }

            [TestMethod]
            public void SumOfSquaresZero()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSumOfSquares(0),0);
            }

            [TestMethod]
            public void SumOfSquaresOne()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSumOfSquares(1), 1);
            }

            [TestMethod]
            public void SumOfSquaresTwo()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateSumOfSquares(2), 5);
            }
        }

        [TestClass]
        public class CalculateDifferenceOfSquares
        {
            [TestMethod]
            public void CanCall()
            {
                DifferenceOfSquares.CalculateDifferenceOfSquares(0);
            }

            [TestMethod]
            public void ZeroCase()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateDifferenceOfSquares(0), 0);
            }

            [TestMethod]
            public void MaxIsOne()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateDifferenceOfSquares(1), 0);
            }

            [TestMethod]
            public void MaxIsTen()
            {
                Assert.AreEqual(DifferenceOfSquares.CalculateDifferenceOfSquares(10), 2640);
            }
        }
    }
}
