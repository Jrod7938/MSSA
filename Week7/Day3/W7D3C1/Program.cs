namespace W7D3C1 {
    internal class Program {
        static void Main(string[] args) {
            BinarySearchTree tree = new BinarySearchTree();

            tree.InsertNode(tree.Root, 100);
            tree.InsertNode(tree.Root, 200);
            tree.InsertNode(tree.Root, 20);
            tree.InsertNode(tree.Root, 300);
            tree.InsertNode(tree.Root, 150);
            tree.InsertNode(tree.Root, 10);
            tree.InsertNode(tree.Root, 30);

            Console.WriteLine("PreOrder");
            tree.PreOrder(tree.Root);
            Console.WriteLine("\nInOrder");
            tree.InOrder(tree.Root);
            Console.WriteLine("\nPostOrder");
            tree.PostOrder(tree.Root);

            

            Console.WriteLine($"\nFound 20: {tree.Search(20)}");
        }
    }
}
