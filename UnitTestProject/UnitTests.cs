using Microsoft.VisualStudio.TestTools.UnitTesting;
using static PracticeTask6.Program;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            a1 = 1;
            double number = A(1);
            Assert.AreEqual(a1, number);
        }

        [TestMethod]
        public void TestMethod02()
        {
            a1 = 1;
            a2 = 2;
            double number = A(2);
            Assert.AreEqual(a2, number);
        }

        [TestMethod]
        public void TestMethod03()
        {
            a1 = 1;
            a2 = 2;
            a3 = 3;
            double number = A(3);
            Assert.AreEqual(a3, number);
        }

        [TestMethod]
        public void TestMethod04()
        {
            a1 = 1;
            a2 = 2;
            a3 = 3;
            double number = A(4);
            Assert.AreEqual(4, 5, number);
        }

        [TestMethod]
        public void TestMethod05()
        {
            a1 = 1;
            a2 = 2;
            a3 = 3;
            N = 4;
            M = 2;
            L = 1;
            bool check = FindNumbersM();
            Assert.AreEqual(true, check);
        }

        [TestMethod]
        public void TestMethod06()
        {
            a1 = 1;
            a2 = 2;
            a3 = 3;
            N = 4;
            M = 2;
            L = 100;
            bool check = FindNumbersM();
            Assert.AreEqual(false, check);
        }
    }
}
