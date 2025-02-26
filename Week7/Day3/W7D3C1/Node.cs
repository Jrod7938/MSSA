namespace W7D3C1 {
    class Node {
        public int data;
        public Node right;
        public Node left;

        public Node(int data, Node right = null, Node left = null) {
            this.data = data;
            this.right = right;
            this.left = left;
        }
    }
}
