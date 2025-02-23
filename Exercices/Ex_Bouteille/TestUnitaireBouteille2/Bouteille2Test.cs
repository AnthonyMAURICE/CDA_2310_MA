using ClassLibraryBouteille2;
using ExceptionBouteille;

namespace TestUnitaireBouteille2
{
    [TestClass]
    public class Bouteille2Test
    {
        [TestMethod]
        public void BouteilleTest_Ouvrir_OuvrirSiFermee_Success()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            //bool expected = true;

            // Act
            bool canBeOpened = bouteilleTest.Ouvrir();

            // Assert
            Assert.AreEqual(true, canBeOpened);

        }

        [TestMethod]
        public void BouteilleTest_Ouvrir_OuvrirSiOuverte_Fail()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = false;

            // Act
            bool canBeOpened = bouteilleTest.Ouvrir();

            // Assert
            Assert.AreEqual(expected, canBeOpened);
        }


        [TestMethod]
        public void BouteilleTest_Fermer_FermerSiOuverte_Success()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = true;

            // Act
            bool canBeClosed = bouteilleTest.Fermer();

            // Assert
            Assert.AreEqual(expected, canBeClosed);

        }

        [TestMethod]
        public void BouteilleTest_Fermer_FermerSiFermee_Fail()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bool expected = false;

            // Act
            bool canBeClosed = bouteilleTest.Fermer();

            // Assert
            Assert.AreEqual(expected, canBeClosed);
        }


        [TestMethod]
        public void BouteilleTest_Remplir_RemplirBouteilleMiPleineOuverte_Success()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bouteilleTest.EstOuverte = true;
            bouteilleTest.QuantiteLiquideEnMl = (bouteilleTest.CapaciteMaxEnMl / 2);
            bool expected = true;

            // Act
            bool filling = bouteilleTest.Remplir(250);

            // Assert
            Assert.AreEqual(expected, filling);
        }

        [TestMethod]
        public void BouteilleTest_Remplir_RemplirBouteilleFermee_Fail()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bouteilleTest.EstOuverte = false;
            bool expected = false;

            // Act
            bool filling = bouteilleTest.Remplir(250);

            // Assert
            Assert.AreEqual(expected, filling);
            
        }

        [TestMethod]
        public void BouteilleTest_Remplir_RemplirBouteillePleine_Fail()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = false;

            // Act
            bool filling = bouteilleTest.Remplir(250);

            // Assert
            Assert.AreEqual(expected, filling);
            Assert.ThrowsException<FullBottleException>(() => bouteilleTest.Remplir(250));
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteillePleineOuverte_Success()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = true;

            // Act
            bool empty = bouteilleTest.Vider(250);

            // Assert
            Assert.AreEqual(expected, empty);
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteilleFermee_Fail()
        {
            // Arrange
            Bouteille2 bouteilleTest = new Bouteille2(1000);
            bool expected = false;

            // Act
            bool empty = bouteilleTest.Vider(250);

            // Assert
            Assert.AreEqual(expected, empty);
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteilleVideOuverte_Fail()
        {
            // Arrange
            Bouteille2 bouteilleTest2 = new Bouteille2(1000);
            bouteilleTest2.EstOuverte = true;
            bouteilleTest2.QuantiteLiquideEnMl = 0;
            bool expected = false;

            // Act
            bool empty = bouteilleTest2.Vider(250);

            // Assert
            Assert.AreEqual(expected, empty);
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteilleVideOuverte_Exception()
        {
            // Arrange
            Bouteille2 bouteilleTest2 = new Bouteille2(1000);
            bouteilleTest2.EstOuverte = true;
            bouteilleTest2.QuantiteLiquideEnMl = 0;

            // Assert
            Assert.ThrowsException<EmptyBottleException>(() => bouteilleTest2.Vider(250));
        }

            [TestMethod]
        public void BouteilleTest_ViderTout_ViderBouteilleMiPleineTestResultatZero_Success()
        {
            // Arrange
            Bouteille2 bouteille = new Bouteille2(1000);
            bouteille.QuantiteLiquideEnMl = bouteille.CapaciteMaxEnMl / 2;
            bouteille.EstOuverte = true;
            double expected = 0;

            // Act

            bouteille.ViderTout();

            // Assert

            Assert.AreEqual(expected, 0);
        }

        [TestMethod]
        public void BouteilleTest_RemplirTout_RemplirBouteilleMiPleineTestResultatCapaciteMax_Success()
        {
            // Arrange
            Bouteille2 bouteille = new Bouteille2(500);
            bouteille.EstOuverte = true;
            double expected = bouteille.CapaciteMaxEnMl;

            // Act

            bouteille.RemplirTout();

            // Assert

            Assert.AreEqual(expected, bouteille.CapaciteMaxEnMl);
        }
    }

}