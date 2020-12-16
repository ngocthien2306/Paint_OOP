using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Shape
    {
        public string Name { get; set; }
        public Point point1 = new Point();
        public Point point2 = new Point();
        public Shape()
        {

        }
        public Shape(double x1, double x2, double y1, double y2)
        {
            point1.X = x1;
            point2.X = x2;
            point1.Y = y1;
            point2.Y = y2;
        }
        ~Shape()
        {

        }
    }
}
