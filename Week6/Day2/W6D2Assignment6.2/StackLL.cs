using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D2Assignment6._2 {
    internal class StackLL<T> {
        public Node<T> top;
        public int size;

        public StackLL() {
            this.top = null;
            this.size = 0;
        }

        // O(1)
        public void Push(T data) {
            Node<T> newHead = new Node<T>(data);
            if (IsEmpty()) {
                top = newHead;
            } else {
                newHead.next = top;
                top = newHead;
            }
            size++;
        }

        // O(1)
        public T Pop() {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is Empty."); }
            T val = top.data;
            top = top.next;
            size--;
            return val;
        }

        // O(1)
        public T Peek() {
            if (IsEmpty()) { throw new InvalidOperationException("Stack is Empty."); }
            return top.data;
        }

        public  bool IsEmpty() { return size == 0; }

        public void Display() {
            if (IsEmpty()) {
                Console.WriteLine("Empty Stack: Nothing to Display.");
                return;
            }
            Node<T> temp = top;
            while(temp != null) {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
