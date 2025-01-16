using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4Assignment {
    public class Student {

        private int studentId;
        private string studentFirstName;
        private string studentLastName;

        private char grade;

        private static int count = 0;


        public int StudentId { get { return studentId; } }
        public string StudentFirstName { 
            get { return studentFirstName; } 
        }
        public string StudentLastName {
            get { return studentLastName; }
        }
        public char Grade {
            get { return grade; }
            set {
                if (new[] {'A', 'B', 'C', 'D', 'F'}.Contains(value)){
                    grade = value;
                }
            }
        }

        public Student(string studentFirstName, string studentLastName, char grade) {
            count++;
            studentId = count;
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            Grade = grade;
        }

        public static void Print(Student student) {
            Console.WriteLine($"Student Name: {student.studentFirstName} {student.studentLastName}\nID: {student.studentId}\nGrade:{student.grade}");
        }
    }
}
