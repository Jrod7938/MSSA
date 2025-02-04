namespace W4D2C3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 200, 100, 30, 1000 };
            list.Sort();
            foreach (int num in list) Console.WriteLine(num);

            List<string> names = new List<string>() { "JC", "Zamorak", "Bill", "Kim", "Jim" };
            names.Sort();
            foreach (string name in names) Console.WriteLine(name);

            List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "JC", Gpa = 3.5f, Age = 20 });
            students.Add(new Student() { Id = 2, Name = "Zamorak", Gpa = 3.0f, Age = 21 });
            students.Add(new Student() { Id = 3, Name = "Bill", Gpa = 2.5f, Age = 22 });
            students.Add(new Student() { Id = 4, Name = "Kim", Gpa = 3.2f, Age = 23 });
            students.Add(new Student() { Id = 5, Name = "Jim", Gpa = 3.8f, Age = 24 });

            students.Sort();
            foreach(Student student in students) Console.WriteLine(student.Name);
            students.Sort(new StudentGPAComparer());
            foreach (Student student in students) Console.WriteLine(student.Name);
        }
    }
}
