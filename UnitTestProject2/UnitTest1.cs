using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab6;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Silnia_0()
        {
            Silnia s = new Silnia(0);
            Assert.AreEqual(s.Oblicz(), 1);
        }
        [TestMethod]
        public void Silnia_1()
        {
            Silnia s = new Silnia(0);
            Assert.AreEqual(s.Oblicz(), 1);
        }
        [TestMethod]
        public void Silnia_5()
        {
            Silnia s = new Silnia(5);
            Assert.AreEqual(s.Oblicz(), 120);
        }
    }
}
