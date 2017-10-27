using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class LinkedList<T> where T : IComparable<T>
    {
        public Node<T> Head;

        public LinkedList()
        {
            Head = null;
        }
        
        public void AddData(T Value)
        {

            if (Head == null)
            {
                Head = new Node<T>(Value);
            }
            else
            {
                Node<T> traversalNode = Head;
                while (traversalNode.NextNode != null)
                {
                    
                    traversalNode = traversalNode.NextNode;
                }
                if (traversalNode.NextNode == null)
                {
                    traversalNode.NextNode = new Node<T>(Value);
                }
            }
        }
        public IEnumerable<Node<T>> Print()
        {
            Node<T> traversalNode = Head;
            while (traversalNode != null)
            {
                yield return traversalNode;
                traversalNode = traversalNode.NextNode;
            }
        }
        public void Remove(T Delete)
        {
            bool Found = false;
            
            Node<T> traversalNode = Head;
            
            while (traversalNode.NextNode != null)
            {

                if (Delete.CompareTo(traversalNode.NextNode.Data) == 0)
                {
                    Found = true;
                    break;
                }
                traversalNode = traversalNode.NextNode;
                
            }
            if (Found == true)
            {
                traversalNode.NextNode = traversalNode.NextNode.NextNode;
            }
            if (Found == false)
            {
                Console.WriteLine("Character Not Found");
            }
        }



    }
}
