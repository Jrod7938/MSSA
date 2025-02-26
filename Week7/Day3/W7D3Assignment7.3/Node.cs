namespace W7D3Assignment7._3 {
    internal class Node {
        public int val;
        public Node left;
        public Node right;

        public Node(int val, Node left = null, Node right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
