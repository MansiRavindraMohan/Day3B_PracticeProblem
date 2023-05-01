using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_PracticeProblem
{
    interface Polygon
    {
        void calculateArea(int a, int b);
    }
    interface Color
    {
        void getColor();
    }
    class Shapes : Polygon, Color
    {
        // implementation of Polygon interface
        public void calculateArea(int a, int b)
        {
            int area = a * b;
            Console.WriteLine("Area of Rectangle: " + area);
        }

        // implementation of Color interface
        public void getColor()
        {
            Console.WriteLine("This is red polygon");
        }
    }
}
