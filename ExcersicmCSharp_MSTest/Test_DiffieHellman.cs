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
        public class PrimeNumberGeneration
        {
            [TestMethod]
            public void Test1()
            {
                BigInteger[] expectedPrimeList = [2, 3];

                CollectionAssert.AreEqual(expectedPrimeList, DiffieHellman.GetPrimeNumberRange(5));
            }

            [TestMethod]
            public void Test2()
            {
                BigInteger[] expectedPrimeList = [2, 3, 5];

                CollectionAssert.AreEqual(expectedPrimeList, DiffieHellman.GetPrimeNumberRange(6));
            }

            [TestMethod]
            public void IsPrimeT1()
            {
                Assert.IsTrue(DiffieHellman.isPrime(5));
            }

            public void IsNotPrimeT2()
            {
                Assert.IsFalse(DiffieHellman.isPrime(4));
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

            [TestMethod]
            public void CheckPrimeThree()
            {
                BigInteger primeP = 3;
                //Random selection of a private key, greater than 1, and less than p (3) will always be 2.
                Assert.AreEqual(DiffieHellman.PrivateKey(primeP), 2);
            }

            [TestMethod]
            public void CheckPrimeFive()
            {
                BigInteger primeP = 5;
                BigInteger result = DiffieHellman.PrivateKey(primeP);
                //Random selection of a private key, greater than 1, and less than p (5) will always be 2 or 3.
                Assert.IsTrue(result == 3 || result == 2, "Expected PrivateKey(" + result + ") to be equal to 2 or 3");
            }
        }

        [TestClass]
        public class PublicKey
        {
            [TestMethod]
            public void Callable()
            {
                DiffieHellman.PublicKey(1,1,1);
            }

            [TestMethod]
            public void ProducesKey()
            {
                Assert.AreEqual(DiffieHellman.PublicKey(1, 1, 2),0);
            }

            [TestMethod]
            public void ProducesKey2()
            {
                Assert.AreEqual(DiffieHellman.PublicKey(5, 2, 7), 3);
            }
        }

        [TestClass]
        public class SecretKey
        {
            [TestMethod]
            public void Callable()
            {
                DiffieHellman.Secret(1, 1, 1);
            }

            [TestMethod]
            public void AllOnes()
            {
                Assert.AreEqual(0, DiffieHellman.Secret(1, 1, 1));
            }

            [TestMethod]
            public void zeroes()
            {
                Assert.AreEqual(0, DiffieHellman.Secret(1, 0, 0));
            }

            [TestMethod]
            public void simple1()
            {
                Assert.AreEqual(1, DiffieHellman.Secret(2, 5, 1));
            }

            [TestMethod]
            public void large1()
            {
                Assert.AreEqual(19, DiffieHellman.Secret(23, 5, 15));
            }
        }
    }
}
