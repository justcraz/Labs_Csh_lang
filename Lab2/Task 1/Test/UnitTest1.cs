using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 19;
            double resultNumber = GetNumName.Program.NameTheNumm(a);
            Assert.AreEqual(19, resultNumber);
        }
    }
}