using System;
namespace NumereComplexe
{
    internal class Complex
    {
        private int a, b;

        public void Print()
        {
            Console.WriteLine("{0} + {1}i", a, b);
        }

        public Complex()
        {
            a = 0;
            b = 0;
        }

        public Complex(int a)
        {
            this.a = a;
            b = 0;
        }

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Complex(string s)
        {
            int x = 0, y = 0, i = 0;

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

            a = x;
            b = y;
        }

        public Complex Add(Complex right)
        {
            int r_a, r_b;

            r_a = a + right.a;
            r_b = b + right.b;

            return new Complex(r_a, r_b);
        }

        public Complex Subtract(Complex right)
        {
            int r_a, r_b;

            r_a = a - right.a;
            r_b = b - right.b;

            return new Complex(r_a, r_b);
        }

        public Complex Multiply(Complex right)
        {
            int r_a, r_b;

            r_a = a * right.a - b * right.b;
            r_b = a * right.b + b * right.a;

            return new Complex(r_a, r_b);
        }

        /*public Complex Divide(Complex right)
        {
            int r_a, r_b;


        }*/

        public static Complex operator+(Complex left, Complex right)
        {
            Complex r = new Complex();

            r.a = left.a + right.a;
            r.b = left.b + right.b;

            return r;
        }

        public override string ToString()
        {
            return "(" + a + ", " + b + ")";
        }

        public int A
        {
            get
            {
                return a;
            }

        }

        public int B
        {
            get
            {
                return b;
            }
        }

    }
}