using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual(CoderTask.csharpExercise.firstNum(123), 1);
            Assert.AreEqual(CoderTask.csharpExercise.lastNum(123, 0), 3);

        }
    }
}