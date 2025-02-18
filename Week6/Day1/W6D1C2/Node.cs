using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D1C2 {
    internal class Node<T> {
        public T data; // data
        public Node<T> next; // address of next node

        public Node(T data, Node<T> next){
            this.data = data;
            this.next = next;
        }

        public Node(T data) {
            this.data = data;
            this.next = null;
        }
    }
}
