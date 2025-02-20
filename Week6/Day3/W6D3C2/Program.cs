namespace W6D3C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueLL<int> queue = new QueueLL<int>();
            queue.Enqueue(23);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(15);
            queue.Display();
            queue.Dequeue();
            Console.WriteLine("After DQ:");
            queue.Display();
        }
    }
}
