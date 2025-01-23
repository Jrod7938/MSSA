using System;
using System.Collections; // older : boxing, unboxing 
using System.Collections.Generic; // newer : generics
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D3C1 {
    internal class Program {
        static void Main(string[] args) {

            int i; // value type
            i = 10;
           
            object obj = new object(); // reference type

            obj = i; // value converted to ref : boxing
            int j = (int)obj; // ref converted to value : unboxing


            Stack myStack1 = new Stack();  //          <---- dont use this 
            myStack1.Push(10);   // int boxing
            myStack1.Push(4.5f); // float boxing
             
            // Generics
            Stack<int> myStack2 = new Stack<int>(); // <---- use this 
            myStack2.Push(j);  // int no boxing
            

            int num1 = 10;
            int num2 = 20;
            
            Console.WriteLine("num1 = " + num1 + " num2 = " + num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("num1 = " + num1 + " num2 = " + num2);


            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine("Before ChangeElements");
            foreach (var num in numbers) {
                Console.WriteLine(num);
            }

            ChangeElements(numbers);
            Console.WriteLine("After ChangeElements");
            foreach (var num in numbers) {
                Console.WriteLine(num);
            }

            var k = new Emp(); // implicitly typed variable
        }

        static void Swap(ref int num1, ref int num2) { // passing original address
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static void ChangeElements(int[] arr) { // base address of array because [] is a reference type
            for(int i = 0; i < arr.Length; i++) {
                arr[i] = arr[i] * 100;
            }
        }
    }
}
