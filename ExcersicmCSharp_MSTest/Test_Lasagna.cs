using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    [TestClass]
    public class TestLasagna
    {
        [TestMethod]
        public void TimeInOvenIs40Min()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(40, lasagna.ExpectedMinutesInOven());
        }

        [TestMethod]
        public void RemainingTimeIn0Case()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(40, lasagna.RemainingMinutesInOven(0));
        }

        [TestMethod]
        public void RemainingTime_NonZero()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(10, lasagna.RemainingMinutesInOven(30));
        }
    }

    [TestClass]
    public class PreparationTime
    {
        [TestMethod]
        public void PrepTime_SimpleCaseZeroInput()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(0, lasagna.PreparationTimeInMinutes(0));
        }

        [TestMethod]
        public void PrepTime_1Layer()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(2, lasagna.PreparationTimeInMinutes(1));
        }


        [TestMethod]
        public void PrepTime_2Layers()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(4, lasagna.PreparationTimeInMinutes(2));
        }
    }

    [TestClass]
    public class ElapsedTime
    {
        [TestMethod]
        public void ZeroInputs()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(0, lasagna.ElapsedTimeInMinutes(0, 0));
        }

        [TestMethod]
        public void OnlyLayers()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(4, lasagna.ElapsedTimeInMinutes(2, 0));
        }

        [TestMethod]
        public void LayersAndOvenTime()
        {
            var lasagna = new Lasagna();
            Assert.AreEqual(26, lasagna.ElapsedTimeInMinutes(3, 20));
        }
    }
}
