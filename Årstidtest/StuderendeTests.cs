using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoomNet60;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60.Tests
{
    [TestClass()]
    public class StuderendeTests
    {
            [TestMethod()]
        public void ÅrstidTest_Vinter()
        {
            // Arrange
            var studerende1 = new Studerende("Test", 1, 15);
            var studerende2 = new Studerende("Test", 2, 15);
            var studerende3 = new Studerende("Test", 12, 15);

            // Act
            var result1 = studerende1.Årstid();
            var result2 = studerende2.Årstid();
            var result3 = studerende3.Årstid();

            // Assert
            Assert.AreEqual("Vinter", result1);
            Assert.AreEqual("Vinter", result2);
            Assert.AreEqual("Vinter", result3);
        }

        [TestMethod()]
        public void ÅrstidTest_Forår()
        {
            // Arrange
            var studerende1 = new Studerende("Test", 3, 15);
            var studerende2 = new Studerende("Test", 4, 15);
            var studerende3 = new Studerende("Test", 5, 15);

            // Act
            var result1 = studerende1.Årstid();
            var result2 = studerende2.Årstid();
            var result3 = studerende3.Årstid();

            // Assert
            Assert.AreEqual("Forår", result1);
            Assert.AreEqual("Forår", result2);
            Assert.AreEqual("Forår", result3);
        }

        [TestMethod()]
        public void ÅrstidTest_Sommer()
        {
            // Arrange
            var studerende1 = new Studerende("Test", 6, 15);
            var studerende2 = new Studerende("Test", 7, 15);
            var studerende3 = new Studerende("Test", 8, 15);

            // Act
            var result1 = studerende1.Årstid();
            var result2 = studerende2.Årstid();
            var result3 = studerende3.Årstid();

            // Assert
            Assert.AreEqual("Sommer", result1);
            Assert.AreEqual("Sommer", result2);
            Assert.AreEqual("Sommer", result3);
        }

        [TestMethod()]
        public void ÅrstidTest_Efterår()
        {
            // Arrange
            var studerende1 = new Studerende("Test", 9, 15);
            var studerende2 = new Studerende("Test", 10, 15);
            var studerende3 = new Studerende("Test", 11, 15);

            // Act
            var result1 = studerende1.Årstid();
            var result2 = studerende2.Årstid();
            var result3 = studerende3.Årstid();

            // Assert
            Assert.AreEqual("Efterår", result1);
            Assert.AreEqual("Efterår", result2);
            Assert.AreEqual("Efterår", result3);
        }
        [DataTestMethod()]
        [DataRow(12, 15, "Vinter")]
        [DataRow(1, 15, "Vinter")]
        [DataRow(2, 15, "Vinter")]
        [DataRow(3, 15, "Forår")]
        [DataRow(4, 15, "Forår")]
        [DataRow(5, 15, "Forår")]
        [DataRow(6, 15, "Sommer")]
        [DataRow(7, 15, "Sommer")]
        [DataRow(8, 15, "Sommer")]
        [DataRow(9, 15, "Efterår")]
        [DataRow(10, 15, "Efterår")]
        [DataRow(11, 15, "Efterår")]

        public void ÅrstidTest(int fødselsmåned, int fødselsdag, string forventet)
        {
            // Arrange
            var studerende = new Studerende("Test", fødselsmåned, fødselsdag);
            // Act
            var resultat = studerende.Årstid();
            // Assert
            Assert.AreEqual(forventet, resultat);
        }
    }
}
