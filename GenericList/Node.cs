using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Node<T>
    {
        public T Data;
        public Node<T> NextNode;
        public Node(T data)
        {
            Data = data;
            NextNode = null;
        }
    }
}
