using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);

            double distance = origin.distanceTo(bottomRight);

            Console.WriteLine($"Distance: {distance}");

            (int xVal, int yVal) = origin;
            Console.WriteLine($"origin: x:{xVal}, y:{yVal}");

            Console.WriteLine($"Point object count: {Point.ObjectCount()}");
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
                //Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
