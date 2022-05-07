using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 5;
            int b = 6;
            
            Assert.AreEqual(11, ConsoleApp1.Program.Example(a, b));
        }
    }
}