using System;

namespace ADT
{
    internal class Stack
    {
        private int[] v;
        private int top = 0;

        public Stack()
        {
            v = new int[16];  
        }

        public void Push(int value)
        {
            if (IsFull)
            {
                Resize(Capacity * 2);
            }
            v[top++] = value;
        }

        private void Resize(int length)
        {
            int[] v2 = new int[length];

            for (int i = 0; i < v2.Length && i < v.Length; i++)
                v2[i] = v[i];

            v = v2;
        }

        public int Peek()
        {
            if (!IsEmpty)
                return v[top - 1];
            else
                throw new StackEmptyException();
        }

        public bool IsEmpty
        {
            get
            {
                return top == 0;
            }
        }

        public bool IsFull
        {
            get
            {
                return top == Capacity;
            }
        }

        public int Capacity
        {
            get
            {
                return v.Length;
            }
        }

        public int Pop()
        {
            if (top > 0)
            {
                if (top < Capacity / 4)
                    Resize(Capacity / 2);
                top--;
                return v[top];
            }
            throw new StackEmptyException("Stiva este goala");
        }

        public int Count
        {
            get
            {
                return top;
            }
        }
    }
}