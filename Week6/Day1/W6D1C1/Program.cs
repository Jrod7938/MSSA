namespace W6D1C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(23);
            list.AddLast(34);
            list.AddLast(56);

            foreach(int node in list) {
                Console.WriteLine(node);
            }

            Console.WriteLine();
            list.AddFirst(11);
            list.AddBefore(list.Find(23), new LinkedListNode<int>(100)); // find value 23, add 100 after it

            foreach (int node in list) {
                Console.WriteLine(node);
            }
        }
    }
}
