using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {

        private Bog bog;
        [TestInitialize]
        public void TestInitialize()
        {
            bog = new Bog("gris", "Daniel", 13, "1234567890123");
        }

        [TestMethod]
        public void TestTitleLenght()
        {
            Assert.AreEqual("gris", bog.Titel);
            bog.Titel = "Gurli gris";
            Assert.AreEqual("Gurli gris", bog.Titel);
        }

        [TestMethod]
        public void TestAuthor()
        {
            Assert.AreEqual("Daniel", bog.Forfatter);
            bog.Forfatter = "Finn";
            Assert.AreEqual("Finn", bog.Forfatter);
        }

        [TestMethod]
        public void TestPageNumber()
        {
            Assert.AreEqual(13, bog.SideTal);
            bog.SideTal = 14;
            Assert.AreEqual(14, bog.SideTal);
        }

        [TestMethod]
        public void TestIsbn()
        {
            Assert.AreEqual("1234567890123", bog.Isbn);
            bog.Isbn = "1234567890987";
            Assert.AreEqual("1234567890987", bog.Isbn);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitelException()
        {
            bog.Titel = "g";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNumberException()
        {
            bog.SideTal = 2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsbnException()
        {
            bog.Isbn = "dej";
        }
    }
}
