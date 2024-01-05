//using Exercice_Barnabe;

namespace TestProject1
{
    [TestClass]
    public class UnitTestBarnabe
    {
        [TestMethod]
        public void TestMethod1()
        {
            int nbeMagasin = Exercice_Barnabe.Program.Courses(1);
            Assert.AreEqual(0, nbeMagasin);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int nbeMagasin = Exercice_Barnabe.Program.Courses(1.5);
            Assert.AreEqual(1, nbeMagasin);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int nbeMagasin = Exercice_Barnabe.Program.Courses(2);
            Assert.AreEqual(1, nbeMagasin);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int nbeMagasin = Exercice_Barnabe.Program.Courses(3);
            Assert.AreEqual(2, nbeMagasin);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int nbeMagasin = Exercice_Barnabe.Program.Courses(0.5);
            Assert.AreEqual(0, nbeMagasin);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int nbeMagasin = Exercice_Barnabe.Program.Courses(0);
            Assert.AreEqual(0, nbeMagasin);
        }
    }
}