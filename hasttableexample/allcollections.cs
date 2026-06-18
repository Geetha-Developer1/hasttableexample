using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasttableexample
{
    internal class allcollections
    {
        public void collections()
        {
            ArrayList al = new ArrayList();
            al.Add("Rama");
            al.Add("Sita");
            al.Add("Ravi");
            al.Add("Shyam");
            al.Add("Rani");
            foreach (var item in al)
            {
                Console.WriteLine("Students are : " + item);
            }
            Hashtable ht = new Hashtable();
            int i = 100;
            Console.WriteLine("\n\n==================================");
            foreach (var item in al)
            {
                
                i++;
                ht.Add(i, item);
            }
            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("Key {0},Value {1}", entry.Key, entry.Value);
            }
            Console.WriteLine("\n\n==================================");
            Queue q = new Queue();
            q.Enqueue("raj");
            q.Enqueue("ravi");
            q.Enqueue("lucky");
            Console.WriteLine("Students que for lunch");
            foreach(var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing a Student from Queue is : "+q.Dequeue());
            Console.WriteLine("Ofter Removing Remaining Students are:");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n==================================");
            Stack s = new Stack();
            s.Push("C# Book");
            s.Push("Python Book");
            s.Push("Java Book");
            Console.WriteLine("Books ina Library");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removing one Book from Library is :" + s.Pop());
            Console.WriteLine("Ofter Removing Remaing Books are:");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }


        }
    }
}
