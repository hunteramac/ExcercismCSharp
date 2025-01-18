using ExcercismCSharp;

namespace ExcersicmCSharp_MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, HelloWorld.getNum());
        }

        [TestMethod]
        public void CheckGreeting()
        {
            Assert.AreEqual("Hello, World!", HelloWorld.Hello());
        }
    }
}