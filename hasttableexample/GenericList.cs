using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hasttableexample
{
    internal class GenericList
    {
        public void listexample()
        {
            List<char> letter = new List<char>();
            letter.Add('A');
 letter.Add('D');
 letter.Add('C');
 letter.Add('E');
 letter.Add('B');
Console.WriteLine("Elements in list : ");
foreach(char i in letter)
{
Console.WriteLine(i);
}
        letter.Sort();
Console.WriteLine("Ofter Sorting : ");
foreach(char i in letter)
{
 Console.WriteLine(i);
}
    letter.Remove('C');
Console.WriteLine("Ofter Removing : ");
foreach(char i in letter)
{
Console.WriteLine(i);
}
Console.WriteLine("Number of elements :" + letter.Count);
letter.Clear();
Console.WriteLine("Number of Elements : " + letter.Count);
Console.WriteLine("======================================");
List<string> word = new List<string>();
word.Add("Rama");
word.Add("Sita");
word.Add("Tej");
word.Add("Venky");
word.Add("Arjun");
Console.WriteLine("Elements in list : ");
foreach (string i in word)
{
    Console.WriteLine(i);
}
word.Sort();
Console.WriteLine("Ofter Sorting : ");
foreach (string i in word)
{
    Console.WriteLine(i);
}

        }
    }
}
