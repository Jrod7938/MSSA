namespace W4D1C4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * List
             * Queue
             * Stack
             * Dictionary
             */
            Stack<int> stack = new Stack<int>();
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Bill");
            Console.WriteLine(queue.Dequeue());

            Dictionary<string, string> recipes = new Dictionary<string, string>(); // creating
            recipes.Add("Clear Soup", "1. Boil Broth..."); // adding
            recipes.Add("Fried Chicken", "1. Heat air fryer to...");

            foreach(var key in recipes.Keys) {
                Console.WriteLine($"{key} {recipes[key]}");
            }

            recipes.Remove("Clear Soup"); // removing
            
        }
    }
}
