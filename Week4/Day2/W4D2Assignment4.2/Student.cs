using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2Assignment4._2 {
    internal class Student : IComparable<Student> {

        private static int count = 0;
        public static List<Student> Students = new List<Student>();

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal GPA { get; set; }

        public Student(string name, decimal gpa) {
            Id = ++count;
            Name = name;
            GPA = gpa;
            Students.Add(this);
        }

        internal static void GenerateStudents() {
            new Student("John Washington", 3.5m);
            new Student("Jane Doe", 3.8m);
            new Student("James Denver", 3.2m);
            new Student("Jill Jefferson", 3.9m);
            new Student("Jack Daniels", 3.7m);
        }

        public int CompareTo(Student? other) {
            return this.GPA.CompareTo(other.GPA);
        }
    }
}
