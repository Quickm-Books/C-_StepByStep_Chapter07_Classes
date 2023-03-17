#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        private int x, y;

        public Point()
        {
            this.x = -1;
            this.y = -1;

            Console.WriteLine("Default Constructor called");
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

            Console.WriteLine($"x:{x}, y:{y}");
        }

        public double distanceTo(Point other)
        {
            double distance = 0.0;

            int xdiff = Math.Abs(other.x - this.x);
            int ydiff = Math.Abs(other.y - this.y);

            distance = Math.Sqrt((xdiff * xdiff) + (ydiff * ydiff));

            return distance;
        }

        public void Deconstruct(out int x, out int y)
        {
            x = this.x;
            y = this.y;
        }
    }
}
