using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Triangle
    {

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public static bool IsTriangleExists(double a, double b, double c)
        {
            throw new NotImplementedException();
        }

        public static bool TestIsTriangleExists(Triangle triangle)
        {
            throw new NotImplementedException();
        }

        public bool IsTriangleExists(Triangle triangle)
        {
            if (triangle.SideA + triangle.SideB > triangle.SideC && triangle.SideA + triangle.SideB >
                triangle.SideB && triangle.SideA + triangle.SideC > triangle.SideA)
            {
                return true;
            
            }
            else
            {
                return false;
            }

        }




    }
}
