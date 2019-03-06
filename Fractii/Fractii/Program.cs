using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractii
{
    class Program
    {
        static void Main(string[] args)
        {
            Fractie f1 = new Fractie();
            Fractie f2 = new Fractie(3, 9);
            Fractie f3 = new Fractie("4 / 8");
            Fractie f4;

            f1.Print();
            f2.Print();
            f3.Print();

            f4 = f2.Add(f3);
            f4.Print();

            f4 = f2.Subtract(f3);
            f4.Print();

            f4 = f2.Multiply(f3);
            f4.Print();

            f4 = f2.Divide(f3);
            f4.Print();
        }
    }
}

