using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercismCSharp
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven() 
        { return 40; }

        public int RemainingMinutesInOven(int minutesInOven) 
        {
            return this.ExpectedMinutesInOven()-minutesInOven;
        }

        public int PreparationTimeInMinutes(int layers)
        {
            return 2*layers;
        }

        public int ElapsedTimeInMinutes(int layers, int minutesInOven)
        {
            return PreparationTimeInMinutes(layers) + minutesInOven;
        }
    }
}
