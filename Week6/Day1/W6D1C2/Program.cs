namespace W6D1C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Linked List");

            LinkedListClass linkedList = new LinkedListClass();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);

            linkedList.Display();

            linkedList.AddLast(3);
            linkedList.Display();
            linkedList.RemoveFirst();
            linkedList.Display();
            linkedList.AddLast(10);
            linkedList.Display();
            linkedList.RemoveLast();
            linkedList.Display();

            int found;
            Console.WriteLine($"{linkedList.Search(3, out found)} index={found}");

            linkedList.AddAnywhere(2, 2);
            linkedList.Display();

            linkedList.RemoveAnywhere(3);
            linkedList.Display();
        }
    }
}
