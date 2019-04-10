using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumereComplexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex("5 + 3i");
            Complex c3;
            Complex c4;

            c3 = c1.Add(c2);
            Console.Write("{0} + {1}i + {2} + {3}i =  ", c1.A, c1.B, c2.A, c2.B);
            c3.Print();

            c3 = c1.Subtract(c2);
            Console.Write("{0} + {1}i - ({2} + {3}i) = ", c1.A, c1.B, c2.A, c2.B);
            c3.Print();

            c3 = c1.Multiply(c2);
            Console.Write("({0} + {1}i) * ({2} + {3}i) = ", c1.A, c1.B, c2.A, c2.B);
            c3.Print();

            Console.WriteLine("*********************");
            Console.WriteLine(c1.ToString());
            c4 = c1 + c2;
        }
    }
}
