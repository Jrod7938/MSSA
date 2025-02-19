namespace W6D2C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Stack<string> operations = new Stack<string>();
            StackArray<int> myStack = new StackArray<int>(10);

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Display();
            myStack.Pop();
            myStack.Display();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Pop();
            myStack.Display();

        }
    }
}
