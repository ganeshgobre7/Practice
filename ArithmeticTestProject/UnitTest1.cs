using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestingPractice;

namespace ArithmeticTestProject
{
    [TestClass]
    public class UnitTest1
    {
        ArithmeticOperation operation = new ArithmeticOperation();
        [TestMethod]
        public void TestMethodAdd()
        {
            int res = operation.Add(10, 20);
            Assert.AreEqual(30, res);
        }

        [TestMethod]
        public void TestMethodSub()
        {
            int res = operation.Sub(10, 20);
            Assert.AreEqual(-10, res);
        }

        [TestMethod]
        public void TestMethodMul()
        {
            int res = operation.Mul(10, 20);
            Assert.AreEqual(300, res);
        }

        [TestMethod]
        public void TestMethodDiv()
        {
            int res = operation.Div(10, 20);
            Assert.AreEqual(20, res);
        }
    }
}
