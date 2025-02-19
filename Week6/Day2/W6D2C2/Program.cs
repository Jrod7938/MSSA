namespace W6D2C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackLL<int> stack = new StackLL<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Display();
            Console.WriteLine("After Pop");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Display();
        }
    }
}
