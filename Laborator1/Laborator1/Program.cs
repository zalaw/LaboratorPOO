using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(5, 0);

            //Console.WriteLine("x = " + A.X  + "\ny = " + A.Y);
            //A.Rotate(90);

            Point p1 = new Point(0, 0);
            Point p2 = new Point(10, 0);
            Point p3 = new Point(5, 10);

            Triunghi t = new Triunghi(p1, p2, p3);

            
        }
    }
}
