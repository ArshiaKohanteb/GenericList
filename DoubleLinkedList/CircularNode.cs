using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    class CircularNode<T>
    {
        public T Data;
        public CircularNode<T> NextNode;
        public CircularNode(T data)
        {
            Data = data;
            NextNode = null;
        }
    }
}
