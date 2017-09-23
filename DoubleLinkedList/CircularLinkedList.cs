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
        public CircularLinkedList<T> Next
        {
            get;
            set;
        }
        public CircularLinkedList<T> Tail
        {
            get;
            set;
        }
        public CircularLinkedList<T> Previous
        {
            get;
            set;
        }
        public T Value { get; set; }
# endregion
        public CircularNode<T> Head;

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
