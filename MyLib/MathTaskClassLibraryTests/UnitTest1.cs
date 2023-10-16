using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using 

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void TestIsTriangleExists()
        {
            Library library = new Library();
            // Создаем треугольник со сторонами 3, 4, 5
            Triangle triangle1 = new Triangle(3, 4, 5);
            bool result1 = library.TestIsTriangleExists(triangle1);
            Console.WriteLine("Треугольник со сторонами 3, 4, 5 существует: " + result1);
            // Создание треугольника со сторонами 1, 2, 3


        }
    }
}
