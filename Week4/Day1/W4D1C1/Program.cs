namespace W4D1C1
{

    /* delegate declaration, funtion pointer.
       can only point to accessible methods with
       same signature.
       Applications:
       1. In event driven programming. Event Handlers
          are related to the events via the delegate.
       2. Anonymous methods/lambda expressions
       3. LINQ : Language Integrated Query
       4. Passing logic to another method. More flexible, 
          reusable.
       5. Call back method in asynchronous programming.
    */
    delegate void Greet(string name);
    delegate int PerformCalculations(params int[] numbers);

    internal class Program
    {

        static void Main(string[] args)
        {
            SayHello("Amy"); // normal dunction call

            Greet myGreeting = new Greet(SayHi);
            
            myGreeting += SayHello; // adding another method, multicast delegate
            myGreeting("JC"); // using delegate

            myGreeting -= SayHello; // removing a method
            myGreeting("Peter");

            // myGreeting += Add; adding a method with different signature doesn't work
            DisplayGreetings(SayHello, "John"); // passing delegate as argument

            Console.WriteLine(Calculate(Add, 10, 20, 30)); 
            Console.WriteLine(Calculate(Multiply, 10, 20, 30)); 
        }

        static void SayHello(string name) {
            Console.WriteLine($"Hello {name}");
        }

        static void SayHi(string name) {
            Console.WriteLine($"Hi {name}");
        }

        static int Add(params int[] numbers) {
            int sum = 0;
            foreach(int number in numbers) sum += number;
            return sum;
        }

        static int Multiply(params int[] numbers) {
            int sum = 1;
            foreach(int number in numbers) sum *= number;
            return sum;
        }

        static void DisplayGreetings(Greet greet, string name) {
            greet(name); // via delegate, we are calling the method
        }

        static int Calculate(PerformCalculations calc, params int[] numbers) {
            return calc(numbers);
        }
    }
}
