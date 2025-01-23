using System;

namespace Week2ChallengeLab {
    struct Student {
        public int RollNumber { get; }
        public string Name { get; }
        public int Physics { get; }
        public int Chemistry { get; }
        public int ComputerApplication { get; }
        public int TotalMarks { get; }
        public double Percentage { get; }
        public string Division { get; }

        public Student(int rollNumber, string name, int physics, int chemistry, int computerApplication) {
            RollNumber = rollNumber;
            Name = name;
            Physics = physics;
            Chemistry = chemistry;
            ComputerApplication = computerApplication;

            TotalMarks = physics + chemistry + computerApplication;
            Percentage = TotalMarks / 3.0;
            Division = Percentage >= 60 ? "First" :
                       Percentage >= 50 ? "Second" :
                       Percentage >= 40 ? "Third" :
                       "Fail";
        }

        public void DisplayDetails() {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {RollNumber}");
            Console.WriteLine($"Name of Student: {Name}");
            Console.WriteLine($"Marks in Physics: {Physics}");
            Console.WriteLine($"Marks in Chemistry: {Chemistry}");
            Console.WriteLine($"Marks in Computer Application: {ComputerApplication}");
            Console.WriteLine($"Total Marks = {TotalMarks}");
            Console.WriteLine($"Percentage = {Percentage:F2}");
            Console.WriteLine($"Division = {Division}");
        }
    }
}