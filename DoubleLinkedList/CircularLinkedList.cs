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
        public CircularNode<T> Next
        {
            get;
            set;
        }
        public CircularNode<T> Tail
        {
            get;
            set;
        }
        public CircularNode<T> Previous
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
                CircularNode<T> TraversalNode = Head;
                while (TraversalNode.NextNode != null)
                {
                    TraversalNode = TraversalNode.NextNode;
                }
                if (TraversalNode.NextNode == null)
                {
                    Previous = TraversalNode;
                    if (Head != null)
                    {
                        TraversalNode.NextNode = Head;
                    }
                    TraversalNode.NextNode = new CircularNode<T>(value);
                    Tail = TraversalNode; 
                }
            }
        }
        public void Remove(T Delete)
        {
            CircularNode<T> traversalNode = Head;

            NodeDelete(Delete);
            bool Found = Contains(Delete);

            if (Found)
            {
                if (Delete.Equals(Head.Data))
                {
                    Head = Head.NextNode;
                    traversalNode = traversalNode.NextNode;
                }
                else if(Delete.Equals(Tail.Data))
                {
                    traversalNode = Head;
                }
                else
                {
                    traversalNode = traversalNode.NextNode;
                }
            }
        }

        private CircularNode<T> NodeDelete(T value)
        {
            CircularNode<T> traversalNode = Head;
            
            bool Found = false;

            while (traversalNode != null)
            {

                if (value.CompareTo(traversalNode.Data) == 0)
                {
                    Found = true;
                    break;
                }
                else
                {
                    Found = false;
                    traversalNode = traversalNode.NextNode;
                }
                
            }
            if (Found)
                {
                traversalNode = traversalNode.PreviousNode;
                }

            Console.WriteLine("Unable to Locate Character Selected");
            return traversalNode;
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
            while (traversalNode != null)
            {
                Console.WriteLine(traversalNode.Data);
                traversalNode = traversalNode.NextNode;
            }
            Console.WriteLine(" ");
        }
        public CircularLinkedList()
        {
            Head = null;
            Previous = null;
        }
        public CircularLinkedList(T value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }

    }
}
