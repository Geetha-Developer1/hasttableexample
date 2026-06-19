using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haqutableexample
{
    internal class GenericQueue
    {
        public void Queueexample()
        {
            Queue<string> qu = new Queue<string>();
            qu.Enqueue("Ganesh");
            qu.Enqueue("Rajesh");
            qu.Enqueue("Ramesh");
            qu.Enqueue("Mahesh");
            Console.WriteLine("Elements in quack : ");
            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Dequeue an element from quack : " + qu.Dequeue());
            foreach (var item in qu)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek an element : " + qu.Peek());
            Console.WriteLine("Number of elements in quack : " + qu.Count);
            qu.Clear();
            Console.WriteLine("Number of elements in quack ofter Clear : " + qu.Count());
            Console.WriteLine("==========================================");
            Queue<char> quc = new Queue<char>();
            quc.Enqueue('b');
            quc.Enqueue('a');
            quc.Enqueue('c');
            quc.Enqueue('d');
            quc.Enqueue('e');
            Console.WriteLine("Elemenets in queue : ");
            foreach(var item in quc)
            {
                Console.WriteLine(item);
            }


        }
    }
}
