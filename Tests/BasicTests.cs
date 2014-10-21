using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.InteropServices;

namespace Tests
{
    [TestClass]
    public class BasicTests
    {
        [TestMethod]
        public void TypeSignatures()
        {
            Assert.IsTrue(typeof(Shape).IsAbstract);
            Assert.AreEqual(typeof(Shape), typeof(Square).BaseType);
            Assert.AreEqual(typeof(Square), typeof(Cube).BaseType);
        }

        [TestMethod]
        public void VirtualFunctions()
        {
            Square s = new Square(Math.PI);
            Assert.AreEqual(4 * Math.PI, s.CountPerimeter());
            Assert.AreEqual(Math.PI * Math.PI, s.CountArea());
            Assert.AreEqual("I'm a square.", s.Introduce());
            Cube c = new Cube(Math.PI);
            Assert.AreEqual(12 * Math.PI, c.CountPerimeter());
            Assert.AreEqual(s.CountPerimeter(), (c as Square).CountPerimeter());
            Assert.AreEqual(Math.PI * Math.PI * 6, c.CountArea());
            Assert.AreEqual(s.CountArea(), (c as Square).CountArea());
            Assert.AreEqual(Math.PI * Math.PI * Math.PI, c.CountVolume());
            Assert.AreEqual("I'm a cube.", c.Introduce());
            Assert.AreEqual("I'm a cube.", (c as Square).Introduce());
        }
    }
}
