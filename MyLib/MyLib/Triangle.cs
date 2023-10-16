using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Triangle
    {

        public double SideA;
        public double SideB;
        public double SideC;
        public bool IsTriangleExists(Triangle triangle)
        {
            if (triangle.SideA + triangle.SideB > triangle.SideC && triangle.SideA + triangle.SideB > triangle.SideB && triangle.SideA + triangle.SideC > triangle.SideA)
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
