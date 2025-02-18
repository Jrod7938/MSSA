using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D1Assignment6._1 {
    internal class HouseLinkedList {
        public HouseNode Head;
        public HouseNode Tail;

        private int size;
        public int Size {  get { return size; } }

        public HouseLinkedList() {
            Head = null;
            Tail = null;
            size = 0;
        }

        public bool IsEmpty() { return size == 0; }

        public void AddFirst(House house, int houseNumber, string address) {
            HouseNode houseNode = new HouseNode(house, houseNumber, address);
            if (IsEmpty()) {
                Head = houseNode;
                Tail = houseNode;
            } else {
                houseNode.Next = Head;
                Head = houseNode;
            }
            size++;
        }

        public void AddLast(House house, int houseNumber, string address) {
            if (IsEmpty()) { AddFirst(house, houseNumber, address); }
            else {
                HouseNode houseNode = new HouseNode(house, houseNumber, address);
                Tail.Next = houseNode;
                Tail = houseNode;
            }
            size++;
        }

        public bool Search(int houseNumber, out HouseNode houseNode) {
            HouseNode current = Head;

            while(current != null) {
                if (current.HouseNumber == houseNumber) { 
                    houseNode = current;
                    return true; 
                }
                current = current.Next;
            }

            houseNode = null;
            return false;
        }
    }
}
