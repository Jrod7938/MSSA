using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D2C2 {
    internal class StackLL<T>{
        Node<T> top;
        int size;

        public StackLL() {
            this.top = null;
            this.size = 0;
        }

        public void Push(T val) {
            Node<T> newHead = new Node<T>(val);
            if (IsEmpty()) {
                top = newHead;
            } else {
                newHead.next = top;
                top = newHead;
            }
            size++;
        }

        public T Pop() {
            if (IsEmpty()) {
                throw new InvalidOperationException("Stack is empty.");
            }
            T val = top.data;
            top = top.next;
            size--;
            return val;
        }

        public T Peek() {
            if (IsEmpty()) {
                throw new InvalidOperationException("Stack is empty.");
            }
            return top.data;
        }

        public bool IsEmpty() { return size == 0; }

        public void Display() {
            if (IsEmpty()) {
                Console.WriteLine("Stack is empty.");
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
