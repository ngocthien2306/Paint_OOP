using System;
using System.Collections.Generic;
using System.Text;

namespace Paint_OOP
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point()
        {

        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        ~Point()
        {

        }
        public virtual void Input()
        {
            Console.Write("Enter point X: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter poiny Y: ");
            Y = Convert.ToDouble(Console.ReadLine());
        }
        public virtual void Output()
        {
            Console.Write("X: {0}", X);
            Console.Write("Y: {0}", Y);
        }
        public virtual void Move(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }
    }
}