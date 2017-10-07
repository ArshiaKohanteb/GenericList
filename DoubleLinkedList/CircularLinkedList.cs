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
                }
            }
        }
        public void Remove(T Delete)
        {
            CircularNode<T> traversalNode = Head;

            bool Found = Contains(Delete);

            if (Found == true)
            {
                traversalNode = traversalNode.NextNode;
            }
        }

        public bool Contains(T value)
        {
            CircularNode<T> traversalNode = Head;

            while (traversalNode.NextNode != null)
            {

                if (value.CompareTo(traversalNode.Data) == 0)
                {
                    return true;
                }
                

            }

            Console.WriteLine("Unable to Delete Character Selected");
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
