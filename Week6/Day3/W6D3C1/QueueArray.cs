using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D3C1 {
    internal class QueueArray {
        private int[] data;
        private int front,
            rear,
            size;

        public QueueArray(int size) {
            this.data = new int[size];
            this.front = -1;
            this.rear = -1;
            this.size = 0;
        }

        public bool IsEmpty() { return this.size == 0; }

        public bool IsFull() { return rear == this.data.Length - 1; }

        public void Enqueue(int val) {
            if(IsFull()) { Console.WriteLine("Q is full, cannot add."); } 
            else {
                if(rear < data.Length - 1) { rear++; }
                data[rear] = val;
                size++;
            }
        }

        public int Dequeue() {
            if (IsEmpty()) { throw new InvalidOperationException("Queue is empty"); } 
            else {
                front++;
                size--;
                int temp = data[front];
                if (IsEmpty()) {
                    this.front = -1;
                    this.rear = -1;
                }
                return temp;
            }
        }

        public void Display() {
            if (!IsEmpty()) {
                for(int i = front + 1; i < rear; i++) { Console.WriteLine(data[i]); }
            } else {
                Console.WriteLine("Queue is empty.");
            }
            Console.WriteLine();
        }
    }
}
