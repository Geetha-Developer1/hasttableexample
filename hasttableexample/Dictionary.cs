using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasttableexample
{
    internal class Dictionary
    {
        public void Dictionaryex()
        {
            Dictionary<int,string> d=new Dictionary<int,string>();
            d.Add(101, "Rama");
            d.Add(102, "Sita");
            d.Add(103, "Raj");
            d.Add(104, "Rani");
            d.Add(105, "Venky");
            Console.WriteLine("Elements in Dictionary : ");
            foreach(var entry in d)
            {
                Console.WriteLine($"Key {entry.Key},Value {entry.Value}");
            }
            Console.WriteLine("\n\n===============================");
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add(".txt", "notepad");
            dic.Add(".docx", "Msword");
            dic.Add(".cs", "CShorp");
            dic.Add(".ts", "Typescript");
            //accept with keys
            Console.WriteLine(".txt file open with " + dic[".txt"]);
            dic.Remove(".docx");
            if (dic.ContainsKey(".docx"))
                Console.WriteLine(".docx open with " + dic[".docx"]);
            else
            {
                dic[".cs"] = "C#";
                foreach (var kvp in dic)
                {
                    Console.WriteLine($"{kvp.Key} {kvp.Value}");
                }
            }

        }
    }
}
