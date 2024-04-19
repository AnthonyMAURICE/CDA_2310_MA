using ClassLibraryBouteille;

namespace TestUnitairesBouteille
{
    [TestClass]
    public class BouteilleTests
    {

        [TestMethod]
        public void BouteilleTest_Ouvrir_OuvrirSiFermee_Succes()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            //bool expected = true;

            // Act
            bool canBeOpened = bouteilleTest.Ouvrir();

            // Assert
            Assert.AreEqual(true, canBeOpened);

        }

        [TestMethod]
        public void BouteilleTest_Ouvrir_OuvrirSiOuverte_Echec()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = false;

            // Act
            bool canBeOpened = bouteilleTest.Ouvrir();

            // Assert
            Assert.AreEqual(expected, canBeOpened);
        }


        [TestMethod]
        public void BouteilleTest_Fermer_FermerSiOuverte_Succes()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = true;

            // Act
            bool canBeClosed = bouteilleTest.Fermer();

            // Assert
            Assert.AreEqual(expected, canBeClosed);

        }

        [TestMethod]
        public void BouteilleTest_Fermer_FermerSiFermee_Echec()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bool expected = false;

            // Act
            bool canBeClosed = bouteilleTest.Fermer();

            // Assert
            Assert.AreEqual(expected, canBeClosed);
        }


        [TestMethod]
        public void BouteilleTest_Remplir_RemplirBouteilleMiPleineOuverte_Succes()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bouteilleTest.EstOuverte = true;
            bouteilleTest.QuantiteLiquideEnMl = (bouteilleTest.CapaciteMaxEnMl / 2);
            bool expected = true;

            // Act
            bool filling = bouteilleTest.Remplir(250);

            // Assert
            Assert.AreEqual(expected, filling);
        }

        [TestMethod]
        public void BouteilleTest_Remplir_RemplirBouteilleFermee_Echec()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bouteilleTest.EstOuverte = false;
            bool expected = false;

            // Act
            bool filling = bouteilleTest.Remplir(250);

            // Assert
            Assert.AreEqual(expected, filling);
        }

        [TestMethod]
        public void BouteilleTest_Remplir_RemplirBouteillePleine_Echec()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bool expected = false;

            // Act
            bool filling = bouteilleTest.Remplir(250);

            // Assert
            Assert.AreEqual(expected, filling);
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteillePleineOuverte_Succes()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bouteilleTest.EstOuverte = true;
            bool expected = true;

            // Act
            bool empty = bouteilleTest.Vider(250);

            // Assert
            Assert.AreEqual(expected, empty);
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteilleFermee_Echec()
        {
            // Arrange
            Bouteille bouteilleTest = new Bouteille(1000);
            bool expected = false;

            // Act
            bool empty = bouteilleTest.Vider(250);

            // Assert
            Assert.AreEqual(expected, empty);
        }

        [TestMethod]
        public void BouteilleTest_Vider_ViderBouteilleVideOuverte_Echec()
        {
            // Arrange
            Bouteille bouteilleTest2 = new Bouteille(1000);
            bouteilleTest2.EstOuverte = true;
            bouteilleTest2.QuantiteLiquideEnMl = 0;
            bool expected = false;

            // Act
            bool empty = bouteilleTest2.Vider(250);

            // Assert
            Assert.AreEqual(expected, empty);
        }

        [TestMethod]
        public void BouteilleTest_ViderTout_ViderBouteilleMiPleineTestResultatZero_Succes()
        {
            // Arrange
            Bouteille bouteille = new Bouteille(1000);
            bouteille.QuantiteLiquideEnMl = bouteille.CapaciteMaxEnMl / 2;
            bouteille.EstOuverte = true;
            double expected = 0;

            // Act

            bouteille.ViderTout();

            // Assert

            Assert.AreEqual(expected, 0);
        }

        [TestMethod]
        public void BouteilleTest_RemplirTout_RemplirBouteilleMiPleineTestResultatCapaciteMax_Succes()
        {
            // Arrange
            Bouteille bouteille = new Bouteille(500);
            bouteille.EstOuverte = true;
            double expected = bouteille.CapaciteMaxEnMl;

            // Act

            bouteille.RemplirTout();

            // Assert

            Assert.AreEqual(expected, bouteille.CapaciteMaxEnMl);
        }
    }
}