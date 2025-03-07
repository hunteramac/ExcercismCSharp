using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    namespace TestRollTheDie
    {
        [TestClass]
        public class RollDie
        {
            [TestMethod]
            public void CanCall()
            {
                var player = new Player();
                player.RollDie();
            }

            [TestMethod]
            public void WithinRangeMultipleTrials()
            {
                var player = new Player(1);
                player.RollDie();

                for(int i = 0; i<100; ++i)
                {
                    int diceRollResult = player.RollDie();
                    Assert.IsTrue(diceRollResult <= 18 && diceRollResult >= 1);
                }
  
            }

        }

        [TestClass]
        public class GenerateSpellStrength()
        {
            [TestMethod]
            public void CanCall()
            {
                var player = new Player();
                player.GenerateSpellStrength();
            }

            [TestMethod]
            public void ResultInRange()
            {
                var player = new Player(1);

                for (int i = 0; i < 1000; ++i)
                {
                    double SpellStrength = player.GenerateSpellStrength();
                    Assert.IsTrue(SpellStrength < 100.0 && SpellStrength >= 0.0);
                }
            }
        }

    }
}