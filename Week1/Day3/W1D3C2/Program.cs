using System;

namespace W1D3C2 {
    internal class Program {
        static void Main(string[] args) {

            int num1,
                num2;

            float result;
        inputnumbers: // label is a named location
            Console.WriteLine("Enter 2 numbers: ");


            bool flag1 = int.TryParse(Console.ReadLine(), out num1);
            bool flag2 = int.TryParse(Console.ReadLine(), out num2);

            try {
                if (flag1 && flag2) {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                } else {
                    Console.WriteLine("Invalid input");
                    goto inputnumbers;
                }
            } catch (DivideByZeroException exception) {
                Console.WriteLine(exception.Message);
                goto inputnumbers;
            } finally {
                // code that is ran regardless if the try succeeded or failed
            }
        }
    }
}
