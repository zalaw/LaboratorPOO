using System;

namespace Number
{
    // Modeleaza un numar natural
    internal class Numar
    {
        private ulong v;

        public Numar(ulong v)
        {
            this.v = v;
        }

        public ulong Value
        {
            get
            {
                return v;
            }
        }

        public ulong SumaCifre()
        {
            ulong suma = 0;
            ulong aux = v;

            while (aux != 0)
            {
                suma += aux % 10;
                aux /= 10;
            }

            return suma;
        }

        public bool EstePrim()
        {
            ulong d = 3;

            if (v < 2)
                return false;
            if (v == 2)
                return true;
            if (v % 2 == 0)
                return false;

            while (d * d <= v)
            {
                if (v % d == 0)
                    return false;
                d += 2;
            }

            return true;
        }

        public ulong NumarDivizori
        {
            get
            {
                ulong nd = 1, d = 2, a = 0, aux = v;

                while (aux != 1)
                {
                    a = 0;

                    while (aux % d == 0)
                    {
                        a++;
                        aux = aux / d;
                    }

                    nd = nd * (a + 1);
                    d++;
                }
                return nd;
            }
        }
        // Nu merge inca
        public ulong SumaDivizori
        {
            get
            {
                ulong d = 2, aux = v, sum = v;

                while (aux != 1)
                {
                    while (aux % d == 0)
                    {
                        aux = aux / d;
                        sum = sum + aux;
                    }
                    sum = sum + v / aux;
                    d++;
                }

                d--;
                if (d * d == v)
                    sum = sum + d;
                return sum;
            }
        }

        public string Hex
        {
            get
            {
                ulong aux = v;
                string placeholder = "", hex = "";

                while (aux != 0)
                {
                    if (aux % 16 == 10)
                        placeholder += "A";
                    else if (aux % 16 == 11)
                        placeholder += "B";
                    else if (aux % 16 == 12)
                        placeholder += "C";
                    else if (aux % 16 == 13)
                        placeholder += "D";
                    else if (aux % 16 == 14)
                        placeholder += "E";
                    else if (aux % 16 == 15)
                        placeholder += "F";
                    else
                        placeholder += aux % 16;
                    aux = aux / 16;
                }

                for (int i = placeholder.Length - 1; i >= 0; i--)
                    hex += placeholder[i];

                return hex;
            }
        }

        public string ConvertToBase(ulong baza)
        {
            ulong aux = v;
            string placeholder = "", hex = "";
            string[] digits = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

            while (aux != 0)
            {
                
                placeholder += digits[aux % baza];
                aux = aux / baza;
            }

            for (int i = placeholder.Length - 1; i >= 0; i--)
                hex += placeholder[i];

            return hex;
        }

        public void Add(Numar x)
        {
            Console.WriteLine("{0} + {1} = {2}", v, x.v, (v + x.v));
        }
    }
}