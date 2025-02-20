using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D2C1 {
    internal class StackArray<T> {
        private T[] data; // stack using array
        private int top; // counter

        public StackArray(int size) {
            data = new T[size];
            top = -1; // -1 for empty
        }

        public bool Push(T val) {
            if (IsFull()) {
                Console.WriteLine("Stack is full!");
                return false;
            } else {
                top++;
                data[top] = val;
                return true;
            }
        }

        public T Pop() {
            if (IsEmpty()) {
                throw new InvalidOperationException("Stack is Empty!");
            }
            T val = data[top];
            top--;
            return val;
        }

        public T Peek() {
            if (IsEmpty()) {
                throw new InvalidOperationException("Stack is Empty!");
            }
            return data[top];
        }

        public bool IsEmpty() { return top == -1; }

        public bool IsFull() { return top == data.Length - 1; }

        public void Clear() {
            data = new T[data.Length];
            top = -1;
        }

        public void Display() {
            if (IsEmpty()) {
                Console.WriteLine("Stack is empty");
                return;
            }
            for(int i = top; i >= 0; i--) {
                Console.WriteLine(data[i]);
            }
        }
    }
}
