using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcercismCSharp
{
    public class Player
    {
        Random random;

        public Player()
        {
            random = new Random();
        }

        public Player(int seed)
        {
            random = new Random(seed);
        }

        public int RollDie()
        {
            return random.Next(1,19);
        }

        public double GenerateSpellStrength()
        {
            return random.NextDouble() * 100.0;
        }
    }
}
