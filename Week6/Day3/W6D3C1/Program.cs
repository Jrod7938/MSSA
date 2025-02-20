namespace W6D3C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Jimmy");
            queue.Enqueue("John");
            queue.Enqueue("Jack");
            foreach(string name in queue) {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Peek: " + queue.Peek());
            Console.WriteLine("Dequeue: " + queue.Dequeue());

            QueueArray myQueue = new QueueArray(10);
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            myQueue.Display();
            myQueue.Dequeue();
            myQueue.Display();
            myQueue.Dequeue();
            myQueue.Dequeue();
            myQueue.Display();
            myQueue.Dequeue();
            myQueue.Display();
        }
    }
}
