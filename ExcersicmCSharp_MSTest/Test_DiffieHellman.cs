using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    namespace TestDiffieHellman
    {
        [TestClass]
        public class Dummy
        {
            [TestMethod]
            public void Test()
            {
                Assert.IsTrue(true);
            }
        }

        [TestClass]
        public class PrivateKey
        {
            [TestMethod]
            public void IsGreaterThenOne()
            {
                BigInteger primeP = 11;
                BigInteger result = DiffieHellman.PrivateKey(primeP);
                Assert.IsTrue(result > 1, "Expected PrivateKey(" + result + ") to be greater than 1");
            }

            [TestMethod]
            public void IsLessThenParameter()
            {
                BigInteger primeP = 11;
                BigInteger result = DiffieHellman.PrivateKey(primeP);
                Assert.IsTrue(result < primeP, "Expected PrivateKey(" + result + ") to be less than PrimeP(" + primeP + ").");
            }

            [TestMethod]
            public void PrimeNumberTwoIsExceptionCase()
            {
                BigInteger primeP = 2;
                Assert.ThrowsException<Exception>(() => DiffieHellman.PrivateKey(primeP));
            }
        }
    }
}
