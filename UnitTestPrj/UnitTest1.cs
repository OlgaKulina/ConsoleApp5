using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp5;

namespace UnitTestPrj
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMult()
        {
            Calculator c = new Calculator();
            double a = 12;
            double b = 5;

            double exp = 60;
            double actual = c.Mult(a, b);
            Assert.AreEqual(exp, actual);

        }

        [TestMethod]
        public void TestDiv()
        {
            Calculator c = new Calculator();
            double a = 100;
            double b = 5;

            double exp = 20;
            double actual = c.Div(a, b);
            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestSub()
        {
            Calculator c = new Calculator();
            double a = 12;
            double b = 5;

            double exp = 7;
            double actual = c.Sub(a, b);
            Assert.AreEqual(exp, actual);
        }

        [TestMethod]
        public void TestSum()
        {
            Calculator c = new Calculator();
            double a = 150;
            double b = 130;

            double exp = 280;
            double actual = c.Sum(a, b);
            Assert.AreEqual(exp, actual);

        }



    }
}
