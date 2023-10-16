using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathTaskClassLibraryTests;
using MyLib;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void isTriangleExist_ValidSides_ReturnsTrue()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool result = Triangle.IsTriangleExists(a, b, c);
            Assert.IsTrue(result);
        }


    }
}
