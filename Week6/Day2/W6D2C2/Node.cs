using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D2C2 {
    internal class Node<T> {
        public T data;
        public Node<T> next;

        public Node(T val, Node<T> next = null){
            this.data = val;
            this.next = next;
        }
    }
}
