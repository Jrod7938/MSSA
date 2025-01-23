using System;
using System.Text;

namespace Week2ChallengeLab {
    internal class Solution {
        /*
        Write a C# Sharp program to read temperature in Fahrenheit and display a suitable message according to temperature state below :
        Temp 0< 10 then Freezing weather
        Temp 11-20 then Very Cold weather
        Temp 21-35 then Cold weather
        Temp 36-50 then Normal in Weather
        Temp 51-65 then Its Hot
        Temp 66-80 then Its Very Hot
        Test Data :
        67
        Expected Output :
        Its very hot.
        */
        internal static void Part1() {
            Console.WriteLine("Enter a temperature in Fahrenheit: ");
            int temp = Convert.ToInt32(Console.ReadLine());

            HandleTemperature(temp);
        }

        private static void HandleTemperature(int temp) {
            if (temp <= 10) {
                Console.WriteLine("Freezing Weather");
            } else if (temp <= 20 && temp > 10) {
                Console.WriteLine("Very Cold Weather");
            } else if (temp <= 35 && temp > 20) {
                Console.WriteLine("Cold Weather");
            } else if (temp <= 50 && temp > 35) {
                Console.WriteLine("Normal Weather");
            } else if (temp <= 65 && temp > 50) {
                Console.WriteLine("It's Hot");
            } else {
                Console.WriteLine("It's Very Hot");
            }
        }


        /*
        Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected.
        */
        internal static void Part2() {
            Console.WriteLine("Enter a username to save: ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter a password to save: ");
            string password = Console.ReadLine();

            HandleLogin(username, password);
        }

        private static void HandleLogin(string username, string password) {
            int attempt = 0;
            while (attempt != 3) {
                Console.WriteLine("Enter a username: ");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("Enter a password: ");
                string inputPassword = Console.ReadLine();
                if(inputUsername == username && inputPassword == password) {
                    Console.WriteLine("Login successful!");
                    break;
                } else {
                    Console.WriteLine("Login failed.");
                    attempt++;
                }
            }
        }

        /*
        Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
        Test Data
        Enter a number: 6
        Enter the desired width: 6
        Expected Output:
        666666
        66666
        6666
        666
        66
        6
        */
        internal static void Part3() {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            HandleTriangle(number, width);
        }

        private static void HandleTriangle(int number, int width) {
            var stringBuilder = new StringBuilder();
            for(int i = width; i >= 1; i--) {
                stringBuilder.AppendLine(new string(char.Parse(number.ToString()), i));
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        /*
        Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. (May use a struct / class to represent the student)
        Test Data :
        Input the Roll Number of the student :784
        Input the Name of the Student :James
        Input the marks of Physics, Chemistry and Computer Application : 70 80 90
        Expected Output :
        Roll No : 784
        Name of Student : James
        Marks in Physics : 70
        Marks in Chemistry : 80
        Marks in Computer Application : 90
        Total Marks = 240
        Percentage = 80.00
        Division = First
        */
        internal static void Part4() {
            Console.Write("Input the Roll Number of the student: ");
            int rollNumber = int.Parse(Console.ReadLine());

            Console.Write("Input the Name of the Student: ");
            string name = Console.ReadLine();

            Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
            string[] marksInput = Console.ReadLine().Split();
            int physics = int.Parse(marksInput[0]);
            int chemistry = int.Parse(marksInput[1]);
            int computerApplication = int.Parse(marksInput[2]);

            Student student = new Student(rollNumber, name, physics, chemistry, computerApplication);
            student.DisplayDetails();
        }
    }
}