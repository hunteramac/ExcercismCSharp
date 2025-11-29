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
    // https://stackoverflow.com/questions/30224589/biginteger-powbiginteger-biginteger
    public static BigInteger BigPow(BigInteger baseValue, BigInteger exponent)
    {
        BigInteger originalValue = baseValue;
        while (exponent-- > 1)
            baseValue = BigInteger.Multiply(baseValue, originalValue);
        return baseValue;
    }

    public static bool isPrime(BigInteger input)
    {
        if (input == 1)
            return false;

        // run division on all numbers between 1 and input, if true, not prime
        BigInteger curInt = 2;
        while (curInt < input)
        {
            if (input % curInt == 0)
                return false;
            ++curInt;
        }

        return true;
    }

    public static BigInteger[] GetPrimeNumberRange(
        BigInteger nonInclusiveMaxRange
        )
    {
        List<BigInteger> result = [];

        BigInteger curInt = 2;
        while (curInt != nonInclusiveMaxRange)
        {
            if (isPrime(curInt))
                result.Add(curInt);

            ++curInt;
        }

        return result.ToArray();
    }

    public static BigInteger PrivateKey(BigInteger p)
    {
        if (p - 1 == 1)
            throw new Exception("primeP must be larger then 2");

        // get a prime number greater then 1, and less than primeP
        BigInteger[] PrimeRange = GetPrimeNumberRange(p);

        Random rand = new Random();
        int choosenElementIndex = rand.Next(PrimeRange.Length);
            
        return PrimeRange[choosenElementIndex];
    }

    public static BigInteger PublicKey(
        BigInteger primeP, 
        BigInteger primeG, 
        BigInteger privateKey)
    {
        return BigPow(primeG, privateKey) % primeP;
        //throw new NotImplementedException(
        //"You need to implement this method."
        //);
    }

    public static BigInteger Secret(
        BigInteger primeP, 
        BigInteger publicKey, 
        BigInteger privateKey)
    {
        return 1;
    }
}
}
