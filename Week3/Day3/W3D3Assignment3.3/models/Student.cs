namespace W3D3Assignment3._3.models {
    internal class Student {
        private static int currentID = 100;
        public static List<Student> Students = new List<Student>();

        public int StudentID { get; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public MonthOfAdmission MonthofAdmission { get; set; }
        public Grade Grade { get; set; }

        public Student(string firstName, string lastName, string address, MonthOfAdmission monthofAdmission, Grade grade) {
            StudentID = currentID;
            currentID++;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MonthofAdmission = monthofAdmission;
            Grade = grade;
        }

        public static void GenerateRecords() {
            Student.Students.Add(new Student("Peter", "Parker", "20 Ingram Street, Queens, NY", MonthOfAdmission.September, Grade.A));
            Student.Students.Add(new Student("Bruce", "Wayne", "1007 Mountain Drive, Gotham", MonthOfAdmission.January, Grade.B));
            Student.Students.Add(new Student("Clark", "Kent", "344 Clinton Street, Metropolis", MonthOfAdmission.August, Grade.C));
            Student.Students.Add(new Student("Tony", "Stark", "10880 Malibu Point, California", MonthOfAdmission.March, Grade.A));
            Student.Students.Add(new Student("Stephen", "Strange", "177A Bleecker Street, New York", MonthOfAdmission.January, Grade.A));
            Student.Students.Add(new Student("Steve", "Rogers", "569 Leaman Place, Brooklyn, NY", MonthOfAdmission.July, Grade.B));
            Student.Students.Add(new Student("Natasha", "Romanoff", "Moscow, Russia", MonthOfAdmission.December, Grade.A));
            Student.Students.Add(new Student("Barry", "Allen", "Central City", MonthOfAdmission.May, Grade.B));
            Student.Students.Add(new Student("Hal", "Jordan", "Coast City", MonthOfAdmission.February, Grade.C));
            Student.Students.Add(new Student("Wanda", "Maximoff", "Sokovia", MonthOfAdmission.November, Grade.A));
            Student.Students.Add(new Student("Bruce", "Banner", "Dayton, Ohio", MonthOfAdmission.April, Grade.B));
            Student.Students.Add(new Student("Arthur", "Curry", "Atlantis", MonthOfAdmission.October, Grade.C));
            Student.Students.Add(new Student("Selina", "Kyle", "Gotham City", MonthOfAdmission.September, Grade.B));
            Student.Students.Add(new Student("Matt", "Murdock", "Hell’s Kitchen, New York", MonthOfAdmission.June, Grade.A));
            Student.Students.Add(new Student("Diana", "Prince", "Themyscira", MonthOfAdmission.June, Grade.C));
        }

        public override string ToString() {
            return $"StudentId: {StudentID}, Name: {FirstName} {LastName}, Address: {Address}, MonthofAdmission: {MonthofAdmission}, Grade: {Grade}";
        }
    }
}
