using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ExcercismCSharp
{
   public static class DiffieHellman
    {
        public static BigInteger PrivateKey(BigInteger primeP)
        {
            if (primeP - 1 == 1)
                throw new Exception("primeP must be larger then 2");
            return primeP-1;
            //throw new NotImplementedException("You need to implement this method.");
        }

        public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey)
        {
            throw new NotImplementedException("You need to implement this method.");
        }

        public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey)
        {
            throw new NotImplementedException("You need to implement this method.");
        }
    }
}
