using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C2 {
    internal class Program {
        static void Main(string[] args) {

            Student student = new Student();
            student.FirstName = "Jancarlos";
            student.LastName = "Rodriguez";
            student.Address = "123 South Park";
            student.Age = 25;
            student.GPA = 3.78f;

            Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}\nAddress: {student.Address}\nAge: {student.Age}\nGPA: {student.GPA}");
            student.Communicate();
            student.DoWork();
            student.FollowSchedule();


            Instructor instructor = new Instructor();
            instructor.FirstName = "Deepali";
            instructor.LastName = "K";
            instructor.Address = "NY";
            instructor.Age = 42;
            instructor.Salary = 140000f;

            Console.WriteLine($"Instructor Name: {instructor.FirstName} {instructor.LastName}\nAddress: {instructor.Address}\nAge: {instructor.Age}\nSalary: {instructor.Salary}");
            instructor.Communicate();
            instructor.DoWork();
            instructor.FollowSchedule();
        }
    }
}
