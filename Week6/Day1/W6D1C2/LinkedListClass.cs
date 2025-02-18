namespace W6D1C2 {
    internal class LinkedListClass {
        private Node<int> head;
        private Node<int> tail;
        private int size;

        public int Size { get { return size; } }

        public LinkedListClass() {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public bool IsEmpty() { return size == 0; }

        // O(1)
        public void AddFirst(int val) {
            Node<int> newNode = new Node<int>(val);
            if (IsEmpty()) {
                this.head = newNode;
                this.tail = newNode;
            } else {
                newNode.next = this.head; // point newNode to existing Node
                this.head = newNode; // update the head
            }
            size++;
        }

        // O(1)
        public void AddLast(int val) {
            Node<int> newNode = new Node<int>(val);
            if (IsEmpty()) {
                AddFirst(val);
            } else {
                this.tail.next = newNode;
                this.tail = newNode;
                this.size++;
            }
        }

        // O(1)
        public int RemoveFirst() {
            if (IsEmpty()) {
                Console.WriteLine("Empty Linked List");
                return -1;
            }
            Node<int> temp = head;
            head = head.next;
            if (IsEmpty()) { tail = null; }
            size--;
            return temp.data;
        }

        // O(n)
        public int RemoveLast() {
            if (IsEmpty()) {
                Console.WriteLine("Empty Linked List");
                return -1;
            }

            if(size == 1) { return RemoveFirst(); }

            Node<int> temp = head;
            int i = 1;
            while(i < size - 1) {
                temp = temp.next;
                i++;
            }
            tail = temp;
            temp = temp.next;
            int val = temp.data;
            tail.next = null;
            
            size--;
            return val;
        }

        // O(n)
        public bool Search(int val, out int index) {
            Node<int> temp = head;
            int i = 1;
            
            while(temp != null) {
                if(temp.data == val) {
                    index = i;
                    return true;
                }
                temp = temp.next;
                i++;
            }
            index = -1;
            return false;
        }

        // O(n)
        public void AddAnywhere(int val, int position) {
            if(position <=0 || position > size + 1) {
                Console.WriteLine("Invalid Position");
                return;
            }
            if(position == 1) {
                AddFirst(val);
            } else if(position == size + 1) {
                AddLast(val);
            } else {
                Node<int> newNode = new Node<int>(val);
                Node<int> temp = head;
                int i = 1;
                while(i < position - 1) {
                    temp = temp.next;
                    i++;
                }

                newNode.next = temp.next;
                temp.next = newNode;
                size++;
            }
        }

        // O(n)
        public int RemoveAnywhere(int position) {
            if (IsEmpty()) {
                Console.WriteLine("Empty Linked List");
                return -1;
            }
            if (position <= 0 || position > size) {
                Console.WriteLine("Invalid Position");
                return -1;
            }
            if(position == 1) {
                return RemoveFirst();
            }
            if(position == size) {
                return RemoveLast();
            }
            Node<int> temp = head;
            int i = 1;
            while (i < position - 1) {
                temp = temp.next;
                i++;
            }
            temp.next = temp.next.next;
            size--;
            return temp.data;
        }

        // O(n)
        public void Display() {
            Node<int> temp = head;
            if (IsEmpty()) { Console.WriteLine("Linked List is empty"); } 
            else {
                while (temp != null) {
                    if (temp.next != null) { Console.Write(temp.data + " -> "); } 
                    else { Console.Write(temp.data); }
                    temp = temp.next;
                }
                Console.WriteLine();
            }
        }
    }
}
