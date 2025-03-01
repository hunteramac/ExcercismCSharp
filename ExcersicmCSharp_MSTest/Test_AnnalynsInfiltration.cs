using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    namespace TestAnnalynsInfiltration { 

        [TestClass]
        public class FastAttack
        {
            [TestMethod]
            public void CanCall()
            {
                QuestLogic.CanFastAttack(true);
            }

            [TestMethod]
            public void KnightAwake()
            {
                Assert.AreEqual(false, QuestLogic.CanFastAttack(true));
            }

            [TestMethod]
            public void KnightSleeping()
            {
                Assert.AreEqual(true, QuestLogic.CanFastAttack(false));
            }
        }

        [TestClass]
        public class CanSpy
        {
            [TestMethod]
            public void CanCall()
            {
                QuestLogic.CanSpy(false, false, false);
            }

            [TestMethod]
            public void NoOneAwake()
            {
                Assert.AreEqual(false, QuestLogic.CanSpy(false, false, false));
            }

            [TestMethod]
            public void KnightAwake()
            {
                Assert.AreEqual(true, QuestLogic.CanSpy(true, false, false));
            }
        }

        [TestClass]
        public class CanFreePrisoner
        {
            [TestMethod]
            public void HaveDog_ArcherAsleep()
            {
                Assert.AreEqual(true, QuestLogic.CanFreePrisoner(true, false, false, true));
            }

            [TestMethod]
            public void HaveDog_ArcherAwake()
            {
                Assert.AreEqual(false, QuestLogic.CanFreePrisoner(true, true, false, true));
            }

            [TestMethod]
            public void Sneaky_KnightArcherAsleep()
            {
                Assert.AreEqual(true, QuestLogic.CanFreePrisoner(false, false, true, false));
            }

            [TestMethod]
            public void Sneaky_OneAwake()
            {
                Assert.AreEqual(false, QuestLogic.CanFreePrisoner(true, true, false, true));
            }
        }
    }
}
