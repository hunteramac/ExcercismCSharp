using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    namespace TestCarsAssemble
    {
        [TestClass]
        public class SuccessRate
        {
            [TestMethod]
            public void CanCall()
            {
                AssemblyLine.SuccessRate(10);
            }

            [TestMethod]
            public void AssemblerSpeedZero()
            {
                Assert.AreEqual(0, AssemblyLine.SuccessRate(0));
            }

            [TestMethod]
            public void AssemblerSpeedTeir1()
            {
                Assert.AreEqual(1, AssemblyLine.SuccessRate(1));
                Assert.AreEqual(1, AssemblyLine.SuccessRate(4));
            }

            [TestMethod]
            public void AssemblerSpeedTeir2()
            {
                Assert.AreEqual(0.9, AssemblyLine.SuccessRate(5));
                Assert.AreEqual(0.9, AssemblyLine.SuccessRate(8));
            }

            [TestMethod]
            public void AssemblerSpeedTeir3()
            {
                Assert.AreEqual(0.8, AssemblyLine.SuccessRate(9));
            }

            [TestMethod]
            public void AssemblerSpeedTeir4()
            {
                Assert.AreEqual(0.77, AssemblyLine.SuccessRate(10));
            }

            [TestMethod]
            public void SpeedOutOfBounds()
            {
                // I think if speed is greater then max, it should default to max
                Assert.AreEqual(0.77, AssemblyLine.SuccessRate(11));

                // lower bound, default to minimum
                Assert.AreEqual(0, AssemblyLine.SuccessRate(-1));
            }
        }
    }
}
