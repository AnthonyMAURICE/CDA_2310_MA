using ClassLibraryBouteille;

namespace TestUnitairesBouteille
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestMethod1()
        { 
            Bouteille bouteilleTest = new Bouteille(1000, false, 1000);

            bool canBeOpened = bouteilleTest.Ouvrir();

            Assert.IsTrue(canBeOpened);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Bouteille bouteilleTest = new Bouteille(1000, false, 1000);
            Bouteille bouteilleTest2 = new Bouteille(1000, true, 1000);

            bool canBeClosed = bouteilleTest.Fermer();
            bool canBeClosed2 = bouteilleTest2.Fermer();

            Assert.IsFalse(canBeClosed);
            Assert.IsTrue(canBeClosed2);
        }

        
        [TestMethod]
        public void TestMethod3()
        {
            Bouteille bouteilleTest = new Bouteille(1000, false, 500);
            Bouteille bouteilleTest2 = new Bouteille(1000, true, 500);
            Bouteille bouteilleTest3 = new Bouteille(1000, true, 1000);

            bool filling = bouteilleTest.Remplir(250);
            bool filling2 = bouteilleTest2.Remplir(250);
            bool filling3 = bouteilleTest3.Remplir(250);

            Assert.IsFalse(filling);
            Assert.IsTrue(filling2);
            Assert.IsFalse(filling3);
        }

        
        [TestMethod]
        public void TestMethod4()
        {
            Bouteille bouteilleTest = new Bouteille(1000, false, 1000);
            Bouteille bouteilleTest2 = new Bouteille(1000, true, 0);
            Bouteille bouteilleTest3 = new Bouteille(1000, true, 1000);

            bool empty = bouteilleTest.Vider(250);
            bool empty2 = bouteilleTest2.Vider(250);
            bool empty3 = bouteilleTest3.Vider(250);

            Assert.IsFalse(empty);
            Assert.IsFalse(empty2);
            Assert.IsTrue(empty3);
        }

        /*
        [TestMethod]
        public void TestMethod5()
        {
            
        }

        
        [TestMethod]
        public void TestMethod6()
        {
           
        }

        [TestMethod]
        public void TestMethod7()
        {
            
        }

        [TestMethod]
        public void TestMethod8()
        {
            
        }

        [TestMethod]
        public void TestMethod9()
        {
            
        }
        */
    }
}