using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class LinkedList<T>
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
        
    }
}
