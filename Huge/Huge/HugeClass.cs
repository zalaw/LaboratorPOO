using System.Text;
using System;

namespace Huge
{
    internal class HugeClass
    {
        private int[] data;
        private int digits;

        public HugeClass()
        {

        }

        public HugeClass(int n)
        {
            digits = CountDigits(n);
            data = new int[digits];

            for (int i = 0; n > 0; i++)
            {
                data[i] = n % 10;
                n /= 10;
            }
        }

        public HugeClass(string s)
        {
            digits = s.Length;
            data = new int[digits];

            for (int i = digits - 1; i >= 0; i--)
            {
                data[digits - 1 - i] = s[i] - '0';
            }

            /*Console.WriteLine("Prelucrare:");
            for (int i = 0; i < digits; i++)
                Console.Write(data[i]);
            Console.WriteLine();*/
        }

        private int CountDigits(int n)
        {
            int counter = 0;

            while (n != 0)
            {
                counter++;
                n /= 10;
            }

            return counter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = digits - 1; i >= 0; i--)
                sb.Append(data[i]);

            return sb.ToString();
        }

        public int Digits
        {
            get
            {
                return digits;
            }
        }

        /*public static HugeClass operator+(HugeClass left, HugeClass right)
        {
            /*HugeClass result = new HugeClass();
            int carry = 0;
            int[] suma = new int[Math.Max(left.Digits, right.Digits) + 1];
            int i, contor = 0;*/


            /*for (i = 0; i < Math.Min(left.Digits, right.Digits); i++)
            {
                suma[i] = (int)(carry + (left.data[i] + right.data[i]) % 10);
                carry = (carry + left.data[i] + right.data[i]) / 10;
                contor++;
            }

            int j = i;
            for (j = i; j < left.Digits; j++)
            {
                suma[j] = (int)(carry + left.data[j] % 10);
                carry = carry + left.data[j] / 10;
                contor++;
            }

            for (j = i; j < right.Digits; j++)
            {
                suma[i] = (int)(carry + right.data[i] % 10);
                carry = carry + right.data[i] / 10;
                contor++;
            }

            if (carry == 1)
            {
                suma[j] = (int)carry;
                contor++;
            }

            result.data = suma;
            result.digits = contor;
            return result;
        }*/

        /*public static HugeClass operator +(HugeClass left, int right)
        {
            HugeClass hugeRight = new HugeClass(right);

            return left + hugeRight;
        }*/
    }
}