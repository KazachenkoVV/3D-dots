using System;
using System.Collections.Generic;
using System.Text;

namespace _3D_dots
{
    class Point
    {
        internal double X { get; private set; }
        internal double Y { get; private set; }
        internal double Z { get; private set; }

        internal Point(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        internal void DispleyPoint()
        {
            Console.WriteLine($"X = {X:f4}");
            Console.WriteLine($"Y = {Y:f4}");
            Console.WriteLine($"Z = {Z:f4}\n");
        }

        public double DistanceBetweenTwoPoints(Point point)
        {
            double dist = 0;
            try
            {
                checked
                {
                    dist = Math.Sqrt(Math.Pow(this.X - point.X, 2) + Math.Pow(this.Y - point.Y, 2) + Math.Pow(this.Z - point.Z, 2));
                }
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dist;
        }

    }
}
