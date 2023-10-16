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
        public void TestIsTriangleExists()
        {
        
            // Создаем треугольник со сторонами 3, 4, 5
            Triangle triangle = new Triangle(3, 4, 5);
            bool result1 = Triangle.TestIsTriangleExists(triangle);
            Console.WriteLine("Треугольник со сторонами 3, 4, 5 существует: " + result1);
            // Создание треугольника со сторонами 1, 2, 3


        }
    }
}
