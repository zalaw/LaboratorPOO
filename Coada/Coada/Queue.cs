using System;

namespace Coada
{
    internal class Queue
    {
        private string[] array;
        private int i = 0;
        private int j = 0;

        public Queue()
        {
            array = new string[4];
            for (int i = 0; i < array.Length; i++)
                array[i] = "null";
        }

        public void Enqueue(string value)
        {
            if (i == array.Length)
            {
                int k = 0;
                while (j < i)
                {
                    array[k] = array[j];
                    k++;
                    j++;
                }
                i = j;
                j = 0;
            }
            array[i++] = value;
        }

        public string Dequeue()
        {
            string data = array[j];

            array[j] = "null";
            j++;

            return data;
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }
    }
}