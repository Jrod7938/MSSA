using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D3C2 {
    internal class Node<T> {
        public T data;
        public Node<T> next;

        public Node(T data, Node<T> next = null) {
            this.data = data;
            this.next = next;
        }
    }
}
