using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7D3Assignment7._3 {
    internal class BinaryTree {
        public Node Root { get; private set; }

        public BinaryTree(Node root = null) {
            this.Root = root;
        }

        public void PrintTree(Node root, int space = 0, int indent = 4) {
            if (root == null) return;

            PrintTree(root.right, space + indent, indent);
            Console.WriteLine(new string(' ', space) + root.val);
            PrintTree(root.left, space + indent, indent);
        }

        internal void InsertNode(Node node) {
            if (Root == null) {
                Root = node;
                return;
            }

            Node current = Root;
            Node parent = null;

            while (current != null) {
                parent = current;
                if (node.val == current.val) {
                    return; 
                } else if (node.val < current.val) {
                    current = current.left;
                } else {
                    current = current.right;
                }
            }

            if (node.val < parent.val) {
                parent.left = node;
            } else {
                parent.right = node;
            }
        }


        internal BinaryTree Search(int number) {
            Node temp = Root;
            while(temp != null) {
                if (temp.val == number) return new BinaryTree(temp);
                else if(temp.val > number) {
                    temp = temp.left;
                } else {
                    temp = temp.right;
                }
            }
            return new BinaryTree();
        }
    }
}
