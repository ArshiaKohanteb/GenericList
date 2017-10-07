using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program 
    {
        static void Main(string[] args)
        {
            CircularLinkedList<int> List = new CircularLinkedList<int>();
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Print();
            List.Remove(1);
            List.Print();
            Console.ReadKey();
        }
    }
}
