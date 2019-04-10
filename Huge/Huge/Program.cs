using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huge
{
    class Program
    {
        static void Main(string[] args)
        {
            HugeClass h1 = new HugeClass(123456789);
            HugeClass h2 = new HugeClass("758");
            HugeClass h3 = new HugeClass("9");

            HugeClass sum = h2 + h3;

            Console.WriteLine(h1);
            Console.WriteLine(h2);
            Console.WriteLine(h3);

            Console.WriteLine("Sum of {0} + {1} = {2}", h2, h3, sum);


            string placeholder = "";
            int carry = 0;
            int 

            for (int i = 0; i < Math.Min(left.Digits, right.Digits); i++)
            {
                placeholder += (left.data[i] + right.data[i] + carry) % 10;
                carry = (left.data[i] + right.data[i]) % 10;
            }

            Console.WriteLine("ALDAD ");
            for (int i = 0; i < placeholder.Length; i++)
                Console.Write(placeholder[i]);
            Console.WriteLine();

            return left + right;




            /*HugeClass product = h2 * h3;

            Console.WriteLine(product);*/

            /*HugeClass h4 = h2 + 12;

            Console.WriteLine("Sum of {0} + {1} = {2}", h2, 12, h4);*/

            /*HugeClass h5 = h1.Power(10);

            Console.WriteLine(h5);*/

            //int mod = h4 % 12345678;


        }
    }
}
