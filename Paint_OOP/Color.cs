using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Color : Point
    {
        public int ColorPoint { get; set; }
        Color()
        {

        }
        Color(double x1, double x2, int colorpoint) : base (x1,x2)
        {
            ColorPoint = colorpoint;
        }
        ~Color()
        {

        }
    }
}
