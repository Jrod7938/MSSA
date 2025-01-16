using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4Assignment {
    public class Solution {

        public static void Part1() {
            Console.Write("Point 1 X: ");
            int.TryParse(Console.ReadLine(), out int point1x);
            Console.Write("Point 1 Y: ");
            int.TryParse(Console.ReadLine(), out int point1y);

            Console.Write("Point 2 X: ");
            int.TryParse(Console.ReadLine(), out int point2x);
            Console.Write("Point 2 Y: ");
            int.TryParse(Console.ReadLine(), out int point2y);

            Point point1 = new Point(point1x, point1y);
            Point point2 = new Point(point2x, point2y);

            Point.Compare(point1, point2);
        }

        public static void Part2() {
            Console.WriteLine("How many students to create?");
            int.TryParse(Console.ReadLine(), out int studentAmount);

            Student[] studentList = new Student[studentAmount];

            for (int i = 0; i < studentAmount; i++) {
                Console.Write("Enter the student first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter the student last name: ");
                string lastName = Console.ReadLine();

                Console.Write("Enter the student grade: ");
                char.TryParse(Console.ReadLine(), out char grade);
                Student student = new Student(firstName, lastName, grade);
                studentList[i] = student;
            }

            foreach (Student student in studentList) {
                Student.Print(student);
            }
        }
    }
}
