using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> LinkedList = new LinkedList<int>();
            LinkedList.AddData(2);
            LinkedList.AddData(3);
            LinkedList.AddData(4);
            LinkedList.AddData(5);
            //LinkedList.Print();
            LinkedList.Remove(30);
            LinkedList.Print();
            Console.ReadKey();
            
        }
    }
}
