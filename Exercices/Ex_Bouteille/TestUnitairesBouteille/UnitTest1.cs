using ClassLibraryBouteille;

namespace TestUnitairesBouteille
{
    [TestClass]
    public class UnitTest1
    {
        Bouteille bouteille2 = new Bouteille(2500, 2000, false);
        [TestMethod]
        public void TestMethod1()
        { 
            bool canBeOpened = bouteille2.Open();
            Assert.IsTrue(canBeOpened);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool negativeVolumeTest = bouteille2.AddQuantity(-2);
            Assert.IsFalse(negativeVolumeTest);
        }


        [TestMethod]
        public void TestMethod3()
        {
            bool addPositiveQuantity = bouteille2.AddQuantity(2);
            Assert.IsTrue(addPositiveQuantity);
        }


        [TestMethod]
        public void TestMethod4()
        {
            bool fillCompletely = bouteille2.FillBottle();
            Assert.IsTrue(fillCompletely);
        }


        [TestMethod]
        public void TestMethod5()
        {
            bool emptyAll = bouteille2.EmptyBottle();
            Assert.IsTrue(emptyAll);
        }


        [TestMethod]
        public void TestMethod6()
        {
            bool removeNegativeAmount = bouteille2.RemoveQuantity(-2);
            Assert.IsFalse(removeNegativeAmount);
        }

        [TestMethod]
        public void TestMethod7()
        {
            bool removeNegativeAmount = bouteille2.RemoveQuantity(2);
            Assert.IsFalse(removeNegativeAmount);
        }
    }
}