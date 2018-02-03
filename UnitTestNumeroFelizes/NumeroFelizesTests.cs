using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroFeliz.Library;

namespace UnitTestNumeroFelizes
{
    [TestClass]
    public class NumeroFelizesTests
    {
        [TestMethod]
        public void ComprobarNumeroTest()
        {
            Assert.AreEqual(true, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(1));
            Assert.AreEqual(false, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(2));
            Assert.AreEqual(false, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(3));
            Assert.AreEqual(true, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(68));
            Assert.AreEqual(false, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(69));
            Assert.AreEqual(true, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(208));
            Assert.AreEqual(true, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(329));
            Assert.AreEqual(false, NumeroFeliz.Library.NumeroFeliz.ComprovarNumero(500));
        }
    }
}
