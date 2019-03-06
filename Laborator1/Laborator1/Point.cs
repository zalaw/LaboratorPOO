using System;

namespace Laborator1
{
    internal class Point
    {
        double x;
        double y;

        public void Rotate(double t)
        {
            t = (Math.PI / 180) * t;
          
            double x1 = x * Math.Cos(t) - y * Math.Sin(t);
            double y1 = y * Math.Cos(t) + x * Math.Sin(t);

            Console.WriteLine("x = " + x1 + "\ny = " + y1);
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public double X
        {
            get
            {
                return x;
            }
        }
            
        public double Y
        {
            get
            {
                return y;
            }
        }
    }
}