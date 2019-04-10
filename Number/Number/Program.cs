using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Numar n = new Numar(1449);

            ulong baza = 16;

            Console.WriteLine("Suma cifrelor numarului {0} este {1}", n.Value, n.SumaCifre());
            Console.WriteLine("Numarul {0} {1} prim", n.Value, n.EstePrim() ? "este" : "nu este");
            Console.WriteLine("Numarul {0} are {1} divizori", n.Value, n.NumarDivizori);
            Console.WriteLine("Numarul {0} are suma divizorilor {1}", n.Value, n.SumaDivizori);
            Console.WriteLine("Numarul {0} din baza 10 in baza 16 este {1}", n.Value, n.Hex);
            Console.WriteLine("Numarul {0} din baza 10 in baza {1} este {2}", n.Value, baza, n.ConvertToBase(baza));

            Numar n1 = new Numar(10);
            Numar n2 = new Numar(5);

            n1.Add(n2);
        }
    }
}
