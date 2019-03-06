using System;

namespace Fractii
{
    internal class Fractie
    {
        private int numarator, numitor;

        public Fractie()
        {
            numarator = 0;
            numitor = 1;
        }

        public Fractie(int numarator, int numitor)
        {
            int d;

            d = gcd(numarator, numitor);
            this.numarator = numarator / d;
            this.numitor = numitor / d;
        }

        public Fractie(string s)
        {
            int x = 0, y = 0, i = 0, d;

            while (s[i] >= '0' && s[i] <= '9')
            {
                x = x * 10 + s[i] - '0';
                i++;
            }
            while (s[i] < '0' || s[i] > '9')
                i++;
            while (i < s.Length && s[i] >= '0' && s[i] <= '9')
            {
                y = y * 10 + s[i] - '0';
                i++;
            }

            d = gcd(x, y);
            numarator = x / d;
            numitor = y / d;
        }

        public Fractie Add(Fractie right)
        {
            int r_numarator, r_numitor;


            r_numitor = numitor * right.numitor;
            r_numarator = numarator * right.numitor + numitor * right.numarator;
                
            return new Fractie(r_numarator, r_numitor);
        }

        public Fractie Subtract(Fractie right)
        {
            int r_numarator, r_numitor;

            r_numitor = numitor * right.numitor;
            r_numarator = numarator * right.numitor - numitor * right.numarator;

            return new Fractie(r_numarator, r_numitor);
        }

        public Fractie Multiply(Fractie right)
        {
            int r_numarator, r_numitor;

            r_numitor = numitor * right.numitor;
            r_numarator = numarator * right.numarator;

            return new Fractie(r_numarator, r_numitor);
        }

        public Fractie Divide(Fractie right)
        {
            int r_numarator, r_numitor;

            r_numitor = numitor * right.numarator;
            r_numarator = numarator * right.numitor;

            return new Fractie(r_numarator, r_numitor);
        }

        public void Print()
        {
            Console.WriteLine(numarator + " / " + numitor);
        }

        public static int gcd(int a, int b)
        {
            int r = a % b;

            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }

            return b;
        }

    }
}