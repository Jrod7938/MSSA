namespace W7D3C1 {
    class BinarySearchTree {
        public Node Root { get; private set; }

        public BinarySearchTree(Node root = null) {
            this.Root = root;
        }

        public bool Search(int val) {
            Node temp = Root;
            while (temp != null) {
                if (temp.data == val) {
                    return true;
                } else if (temp.data < val) {
                    temp = temp.right;
                } else {
                    temp = temp.left;
                }
            }
            return false;
        }

        public void InsertNode(Node tempRoot, int val) {
            Node newNode = new Node(val);
            Node temp = null;

            if (Root != null) {
                while (tempRoot != null) {
                    temp = tempRoot;
                    if (tempRoot.data == val) return;
                    else if (val < tempRoot.data) {
                        tempRoot = tempRoot.left;
                    } else if (val > tempRoot.data) {
                        tempRoot = tempRoot.right;
                    }
                }

                if (val < temp.data) {
                    temp.left = newNode;
                } else {
                    temp.right = newNode;
                }

            } else {
                Root = newNode;
            }

        }

        public void InOrder(Node tempRoot) {
            if (tempRoot != null) {
                InOrder(tempRoot.left);
                Console.Write(tempRoot.data + " ");
                InOrder(tempRoot.right);
            }
        }

        public void PostOrder(Node tempRoot) {
            if(tempRoot != null) {
                PostOrder(tempRoot.left);
                PostOrder(tempRoot.right);
                Console.Write(tempRoot.data + " ");
            }
        }

        public void PreOrder(Node tempRoot) {
            if(tempRoot != null) {
                Console.Write(tempRoot.data + " ");
                PreOrder(tempRoot.left);
                PreOrder(tempRoot.right);
            }
        }
    }
}
