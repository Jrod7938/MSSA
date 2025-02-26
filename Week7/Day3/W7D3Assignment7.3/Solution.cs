using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace W7D3Assignment7._3 {
    static class Solution {

        // You are given the root of a binary search tree(BST) and an integer val.
        // Find the node in the BST that the node's value equals val and return
        // the subtree rooted with that node. If such a node does not exist, return
        // null.
        public static void Part1() {
            int nodeAmount = GetInput<int>("Enter the amount of nodes in the tree: ");
            BinaryTree tree = new BinaryTree();
            for(int i = 0; i < nodeAmount; i++) {
                tree.InsertNode(new Node(GetInput<int>($"Enter node {i + 1}: ")));
            }
            Console.WriteLine("\nCurrent Tree Sideways: ");
            tree.PrintTree(tree.Root);

            int number = GetInput<int>("Enter a number to search for: ");
            BinaryTree result = tree.Search(number);

            Console.WriteLine("\nTree After Search Sideways : ");
            result.PrintTree(result.Root);
        }

        private static T GetInput<T>(string prompt){
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }catch(Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}
