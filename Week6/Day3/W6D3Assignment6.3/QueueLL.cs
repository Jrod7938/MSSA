using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D3Assignment6._3 {
    internal class QueueLL<T> {
        Node<T> front;
        Node<T> rear;
        int size;

        public QueueLL() {
            this.front = null;
            this.rear = null;
            this.size = 0;
        }

        public bool IsEmpty() { return this.size == 0; }

        public void Enqueue(T val) {
            Node<T> newNode = new Node<T>(val);
            if (IsEmpty()) {
                front = newNode;
            } else {
                rear.next = newNode; 
            }
            rear = newNode; 
            size++;
        }

        public T Peek() { return front.data; }

        public T Dequeue() {
            if (IsEmpty()) { throw new InvalidOperationException("Queue is empty"); }
            Node<T> temp = front;
            front = front.next;
            size--;
            return temp.data;
        }

        public void Display() {
            if (IsEmpty()) { Console.WriteLine("Queue is empty"); return; }
            Node<T> current = front;
            while (current != null) {
                Console.Write(current.data + " ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
