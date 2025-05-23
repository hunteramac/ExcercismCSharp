﻿using ExcercismCSharp;
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
        public class NumberOfLiveNeighbors
        {


            [TestMethod]
            public void OneCell()
            {
                int[,] matrix = new int[,] {
                    { 1 }
                };

                Assert.AreEqual(0, GameOfLife.numberOfLiveNeighbors(0, 0, matrix));
            }

            [TestMethod]
            public void HasOneLiveNeighbor()
            {
                int[,] matrix = new int[,] {
                    { 1, 1 }
                };

                Assert.AreEqual(1, GameOfLife.numberOfLiveNeighbors(0, 0, matrix));

            }

            [TestMethod]
            public void HasTwoLiveNeighborsHorizontally()
            {
                int[,] matrix = new int[,] {
                    { 1, 1, 1}
                };

                Assert.AreEqual(2, GameOfLife.numberOfLiveNeighbors(1, 0, matrix));

            }

            [TestMethod]
            public void HasTwoLiveNeighborsVertHz_LeftCorner()
            {
                int[,] matrix = new int[,] {
                    { 1, 1},
                    { 1, 0}
                };

                Assert.AreEqual(2, GameOfLife.numberOfLiveNeighbors(0, 0, matrix));

            }

            [TestMethod]
            public void HasTwoLiveNeighborsUpAndDiagonal()
            {
                int[,] matrix = new int[,] {
                    { 1, 1},
                    { 1, 0}
                };

                Assert.AreEqual(2, GameOfLife.numberOfLiveNeighbors(0, 1, matrix));

            }

            [TestMethod]
            public void Has8LiveNeighbors()
            {
                int[,] matrix = new int[,] {
                    { 1, 1, 1},
                    { 1, 1, 1},
                    {1, 1, 1 }
                };

                Assert.AreEqual(8, GameOfLife.numberOfLiveNeighbors(1, 1, matrix));

            }

            [TestMethod]
            public void HasNoNeighborsCentral()
            {
                int[,] matrix = new int[,] {
                    { 0, 0, 0},
                    { 0, 1, 0},
                    {0, 0, 0 }
                };

                Assert.AreEqual(0, GameOfLife.numberOfLiveNeighbors(1, 1, matrix));

            }

            [TestMethod]
            public void BottomCorner()
            {
                int[,] matrix = new int[,] {
                    { 0, 0, 0},
                    { 0, 1, 1},
                    {0, 1, 1 }
                };

                Assert.AreEqual(3, GameOfLife.numberOfLiveNeighbors(2, 2, matrix));

            }

        }

        [TestClass]
        public class CanLiveOn
        {
            [TestMethod]
            public void CanCall()
            {
                int[,] matrix = new int[,] {
                    { 0, 0 },
                    { 1, 0 },
                };

                Assert.IsFalse(GameOfLife.canLiveOn(0, 1, matrix));
            }

            [TestMethod]
            public void HasTwoNeighbors()
            {
                int[,] matrix = new int[,] {
                    { 1, 1 },
                    { 1, 0 },
                };

                Assert.IsTrue(GameOfLife.canLiveOn(0, 0, matrix));
            }
        }


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

                CollectionAssert.AreEqual(GameOfLife.Tick(inputMatrix), resultMatrix);
            }

            [TestMethod]
            public void OneLiveCellDies()
            {
                int[,] inputMatrix = new int[,] {
                    { 1 }
                };

                int[,] resultMatrix = new int[,] {
                    { 0 }
                };

                CollectionAssert.AreEqual(GameOfLife.Tick(inputMatrix), resultMatrix);
            }

            [TestMethod]
            public void TwoLiveCellsNotNeighbors()
            {
                int[,] inputMatrix = new int[,] {
                    { 1, 0, 1 }
                };

                int[,] resultMatrix = new int[,] {
                    { 0, 0, 0 }
                };

                CollectionAssert.AreEqual(GameOfLife.Tick(inputMatrix), resultMatrix);
            }

            [TestMethod]
            public void AliveMiddleCellBetweenTwoAliveStillDies()
            {
                int[,] inputMatrix = new int[,] {
                    { 1, 1, 1 }
                };

                int[,] resultMatrix = new int[,] {
                    { 0, 1, 0 }
                };

                CollectionAssert.AreEqual(GameOfLife.Tick(inputMatrix), resultMatrix);
            }

            // Do the rules get applied, without affecting each other?

            [TestMethod]
            public void CornerCaseHas2Neighbors()
            {
                int[,] inputMatrix = new int[,]
                {
                    { 1, 1 },
                    { 1, 0 }
                };

                int[,] resultMatrix = new int[,]
                {
                        { 1, 1 },
                        { 1, 1 }
                };

                CollectionAssert.AreEqual(GameOfLife.Tick(inputMatrix), resultMatrix);
            }
        }
    }
}
