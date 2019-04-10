using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayClass ma = new MyArrayClass(8);

            for (int i = 0; i < 10; i++)
            {
                ma.Add(i * i);
            }

            Console.WriteLine("Capacity: {0}", ma.Capacity);

            Console.WriteLine(ma);

            ma[3] += 5;

            Console.WriteLine(ma);

            // Elimina toate aparitiile numarului 14
            ma.Remove(5);
            Console.WriteLine(ma);

            // Cautare liniara
            // Daca nu este gasita valoarea, metoda intoarce false si index are valoare -1
            int value = 81, index;
            bool found = ma.Find(value, out index);

            // Suma elementelor din vector
            int sum = ma.Sum();
            Console.WriteLine("{0}*", sum);

            // Intoarce un vector cu indicii valorii respective
            value = 11;
            MyArrayClass indexes = ma.FindAll(value);
            if (indexes.Capacity == 0)
            {
                Console.WriteLine("{0} not found*", value);
            }
            else
            {
                Console.Write("{0} is at indexes ", value);
                Console.WriteLine(indexes + "*");
            }
            

            // Modifica vectorul (rearanjeaza elementele)
            //ma.BubbleSort();
            //Console.WriteLine(ma);
            //ma.InsertionSort();
            //Console.WriteLine(ma);
            ma.SelectionSort();
            Console.WriteLine(ma);

            // Muta toate elementele din vector cu o poziti la stanga si primul element ajunge pe ultima pozitie
            ma.RotateLeft();
            Console.WriteLine(ma);
        }
    }
}
