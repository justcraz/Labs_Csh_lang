using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {

        double a = 3;
        double b = 4;

        [TestMethod]
        public void TestMethod1()
        {
            double resultHypotenuse = TriangleApp.Program.Hypotenuse(a, b, true);
            
            Assert.AreEqual(5, resultHypotenuse);
        }


        [TestMethod]
        public void TestMethod2()
        {
            double resultPerimeter = TriangleApp.Program.Perimeter(a, b);
            Assert.AreEqual(12, resultPerimeter);
        }
    }
}