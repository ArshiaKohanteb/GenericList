using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class CircularLinkedList<T> where T : IComparable<T>
    {
        #region Properties
        
        public CircularNode<T> Tail
        {
            get;
            set;
        }
        
        public T Value { get; set; }
        #endregion
        public CircularNode<T> Head;

        public void Add(T value)
        {
            if (Head == null)
            {
                Head = new CircularNode<T>(value);
                Tail = Head;
            }
            else
            {
                CircularNode<T> TraversalNode = Tail;
                TraversalNode.NextNode = new CircularNode<T>(value);
                Head.PreviousNode = TraversalNode.NextNode;
                Tail = TraversalNode.NextNode;
                Tail.PreviousNode = TraversalNode;
                Tail.NextNode = Head;
                
            }
        }
        public void Remove(T Delete)
        {
            CircularNode<T> traversalNode = Head;

            
            bool Found = Contains(Delete);

            if (Found)
            {
                if (Delete.Equals(Head.Data))
                {
                    Head = Head.NextNode;
                    Head.PreviousNode = Tail;
                }
                else if(Delete.Equals(Tail.Data))
                {
                    CircularNode<T> NewTail = Tail.PreviousNode; 
                    Tail = null;
                    Tail = NewTail;
                    NewTail = null;
                    Head.PreviousNode = Tail;
                    Tail.NextNode = Head;
                }
                else
                {
                    traversalNode = null;
                    traversalNode = traversalNode.NextNode;
                }
            }
        }

       
        public bool Contains(T value)
        {
            CircularNode<T> traversalNode = Head;

            while (traversalNode != null)
            {

                if (value.CompareTo(traversalNode.Data) == 0)
                {
                    return true;
                }
                else
                {
                    traversalNode = traversalNode.NextNode;
                }

            }

            Console.WriteLine("Unable to Locate Character Selected");
            return false;
        }

        public void Print()
        {
            CircularNode<T> traversalNode = Head;
            while (traversalNode != Tail)
            {
                Console.WriteLine(traversalNode.Data);
                traversalNode = traversalNode.NextNode;
            }
            Console.WriteLine(Tail.Data);
            Console.WriteLine(" ");

        }

        public IEnumerable<CircularNode<T>> Nodes()
        {
            CircularNode<T> temp = Head;
            if (temp == null) yield break;
            yield return temp;
            temp = temp.NextNode;

            while(temp != null && temp != Head)
            {
                yield return temp;
                temp = temp.NextNode;
            }


        }

        public CircularLinkedList()
        {
            Head = null;
            
        }
        public CircularLinkedList(T value)
        {
            Value = value;
            
        }

    }
}
