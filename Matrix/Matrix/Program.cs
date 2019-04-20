using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(2);
            Matrix m2 = new Matrix(2);
            Matrix m3 = new Matrix(6);

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);

            m1.RandomInit(10);
            Console.WriteLine(m1);

            m2.RandomInit(10);
            Console.WriteLine(m2);

            m3.RandomInit(1000000);
            Console.WriteLine(m3);

            Matrix p = m1 * m2;
            Console.WriteLine(p);

            
            Matrix t = p.Transpose();

            Console.WriteLine(t);

            
            if (m1 == m2)
            {
                Console.WriteLine("Matricile m1 si m2 sunt egale.");
            }
            else
            {
                Console.WriteLine("Matricile m1 si m2 nu sunt egale.");
            }

            /*
            if (t.Rare())
            {
                RareMatrix rm = new RareMatrix(t);
            }
            */
        }
    }
}
