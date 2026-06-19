using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasttableexample
{
    internal class GenericStack
    {
        public void stackexample()
        {
            Stack<string> st = new Stack<string>();
            st.Push("Ganesh");
            st.Push("Rajesh");
            st.Push("Ramesh");
            st.Push("Mahesh");
            Console.WriteLine("Elements in stack : ");
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Pop an element from stack : " + st.Pop());
            foreach(string item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Peek an element : " + st.Peek());
            Console.WriteLine("Number of elements in stack : " + st.Count);
            st.Clear();
            Console.WriteLine("Number of elements in stack ofter Clear : " + st.Count());
            Console.WriteLine("==========================================");
            Stack<double> std=new Stack<double>();
            std.Push(10.5);
            std.Push(20.5);
            std.Push(30.5);
            std.Push(50.5);
            std.Push(40);
            Console.WriteLine("Elements in stack : ");
            foreach (var item in std)
            {
                Console.WriteLine(item);
            }

                Console.WriteLine("Pop an element form the stack : " + std.Pop());
                Console.WriteLine("Peek an element : " + std.Peek());
                Console.WriteLine("Number of elements in stack : " + std.Count);
                std.Clear();
                Console.WriteLine("Number of elements in stack ofter clear : " + std.Count());
            
        }
    }
}
