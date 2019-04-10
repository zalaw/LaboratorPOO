using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADT
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            // Introduce un element in stiva
            st.Push(1);
            st.Push(2);
            st.Push(3);

            // Elimina un element din stiva
            int v = st.Pop();

            st.Push(4);

            // Returneaza elementul din varful stivei fara a-l elimina
            Console.WriteLine("Elementul din varf: {0}", st.Peek());

            // Returneaza numarul de elemente din stiva
            Console.WriteLine("Numarul elementelor din stiva: {0}", st.Count);

            // Returneaza numarul maxim de elemente pe care le putem introduce in stiva
            Console.WriteLine("Lungimea stivei: {0}", st.Capacity);

            st.Pop();
            st.Pop();
            st.Pop();

            Console.WriteLine(st.IsEmpty);
            Console.WriteLine(st.IsFull);
            // Instructiunea va lansa exceptie
            st.Pop();
        }
    }
}
