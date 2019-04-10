using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coada
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue coada = new Queue();

            coada.Enqueue("5");
            coada.Enqueue("10");
            coada.Enqueue("2");

            coada.Print();

            Console.WriteLine("Dequeuing '{0}'", coada.Dequeue());
            Console.WriteLine("Dequeuing '{0}'", coada.Dequeue());

            coada.Print();

            coada.Enqueue("11");
            coada.Enqueue("9");

            coada.Print();
            
        }
    }
}
