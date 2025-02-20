namespace W6D3Assignment6._3 {
    internal static class Solution {
        // You are developing a program to manage a call queue of customers using the Queue in C#.
        // The program creates a queue of callers and demonstrates the functionality of enqueueing
        // elements into the queue and iterating over the elements and dequeuing.
        // Use linked lists.
        public static void Part1() {
            bool run = true;
            QueueLL<string> queue = new QueueLL<string>();
            while (run) {
                int option = GetInput<int>("Call Center: \n1. Add Caller \n2. Remove Caller\n3. See Current Caller\n4. Show All Callers\n");
                switch (option) {
                    case 1:
                        queue.Enqueue(GetInput<string>("Enter a Caller to add: "));
                        break;
                    case 2:
                        Console.WriteLine(queue.Dequeue());
                        break;
                    case 3:
                        Console.WriteLine(queue.Peek());
                        break;
                    case 4:
                        queue.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid input, closing program.");
                        run = false;
                        break;
                }
            }
        }

        private static T GetInput<T>(string prompt) {
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
