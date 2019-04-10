using System;
using System.Text;

namespace MyArray
{
    internal class MyArrayClass
    {
        private int[] arr;
        private int size;

        public MyArrayClass()
        {
            arr = new int[64];
            size = 0;
        }

        public MyArrayClass(int n)
        {
            arr = new int[n];
            size = 0;
        }

        public int Capacity
        {
            get
            {
                return arr.Length;
            }
        }

        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                Console.WriteLine("*Changing value at index {0}, old value: {1}, new value: {2}*", i, arr[i], value);
                arr[i] = value;
            }
        }

        public void Add(int value)
        {
            if (size < arr.Length)
            {
                arr[size] = value;
                size++;
            }
            else
            {
                int[] newArr = new int[arr.Length * 2];

                for (int i = 0; i < arr.Length; i++)
                    newArr[i] = arr[i];

                newArr[size] = value;
                size++;

                arr = newArr;
            }
        }

        public void Remove(int value)
        {
            int i = 0;
            bool found = false;

            Console.Write("*Removing every instance of {0} from array... ", value);

            while (i < size)
            {
                if (arr[i] == value)
                {
                    found = true;
                    for (int j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    size--;
                }
                else
                {
                    i++;
                }
            }

            if (found)
            {
                Console.WriteLine("{0} removed from array*", value);
            }
            else
            {
                Console.WriteLine("{0} not found*", value);
            }
        }

        public bool Find(int value, out int index)
        {
            Console.Write("*Finding {0}... ", value);
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    index = i;
                    Console.WriteLine("{0} first found at index {1}*", value, index);
                    return true;
                }
            }

            index = -1;
            Console.WriteLine("{0} not found*", value);
            return false;
        }

        public int Sum()
        {
            int sum = 0;

            Console.Write("*Performing sum of elements... ");

            for (int i = 0; i < size; i++)
                sum += arr[i];

            return sum;
        }

        public MyArrayClass FindAll(int value)
        {
            Console.Write("*Performing find all... ");
            
            int length = 0;
            MyArrayClass indexes;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    length++;
                }
            }

            indexes = new MyArrayClass(length);

            for (int i = 0; i < size; i++)
            {
                if (arr[i] == value)
                {
                    indexes.Add(i);
                }
            }

            return indexes;
        }

        public void BubbleSort()
        {
            Console.WriteLine("BubbleSort");
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 0; i < size - 1; i++)
                {
                    if (arr[i + 1] < arr[i])
                    {
                        swapped = true;
                        int aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                    }
                }
            } while (swapped);
        }

        public void InsertionSort()
        {
            Console.WriteLine("Insertion Sort");

            for (int i = 1; i < size; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[i] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        public void SelectionSort()
        {
            Console.WriteLine("Selection Sort");

            for (int i = 0; i < size - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                int aux = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = aux;
            }
        }

        public void RotateLeft()
        {
            Console.WriteLine("Rotate Left");
            int key = arr[0];

            for (int i = 0; i < size - 1; i++)
                arr[i] = arr[i + 1];

            arr[size - 1] = key;
        }

        public override string ToString()
        {
            string result = "[";

            for (int i = 0; i < size; i++)
            {
                result += arr[i];
                if (i != size - 1)
                {
                    result += ", ";
                }
                
            }

            result += "]";

            return result;
        }
    }
}