using ExcercismCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersicmCSharp_MSTest
{
    namespace TestGameOfLife
    {
        [TestClass]
        public class Tick
        {
            [TestMethod]
            public void CanCall()
            {
                int[,] matrix = new int[,] {
                    { 0, 0 },
                    { 1, 0 },
                };
                GameOfLife.Tick(matrix);
            }

            [TestMethod]
            public void OneCellDead()
            {
                int[,] inputMatrix = new int[,] {
                    { 0 }
                };

                int[,] resultMatrix = new int[,] {
                    { 0 }
                };

                Assert.AreEqual(GameOfLife.Tick(inputMatrix),resultMatrix);
            }
        }
    }
}
