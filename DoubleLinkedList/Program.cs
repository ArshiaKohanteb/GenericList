using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class Program 
    {/// <summary>
     ///Work on  NodeDelete 
     /// </summary>

        static void Main(string[] args)
        {
            string[] words = { "Hi", "this", "is", "a", "sentence" };
           
            CircularLinkedList<string> List = new CircularLinkedList<string>();
            List.Add("1");
            List.Add("2");
            List.Add("3");
            
            
            foreach(CircularNode<string> node in List.Nodes())
            {
                Console.WriteLine(node.Data);
            }
            Console.ReadKey();
        }
    }
}
