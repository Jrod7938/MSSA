namespace W10D2Assignment10._2 {
    class Solution {
        public static void Part2() {
            List<Employee> employees = new List<Employee> {
            new Employee { Name = "John", Age = 25, Salary = 6000 },
            new Employee { Name = "Alice", Age = 32, Salary = 7000 },
            new Employee { Name = "Bob", Age = 28, Salary = 5500 },
            new Employee { Name = "Charlie", Age = 29, Salary = 4000 },
            new Employee { Name = "David", Age = 27, Salary = 6500 }
            };

            var filteredEmployees = from emp in employees
                                    where emp.Salary > 5000 && emp.Age < 30
                                    select emp;

            Console.WriteLine("\nPart 2: Employees List:");
            foreach (var emp in employees) {
                Console.WriteLine($"{emp.Name} - Age: {emp.Age}, Salary: {emp.Salary}");
            }
            Console.WriteLine("\nPart 2: Employees with salary > 5000 and age < 30:");
            foreach (var emp in filteredEmployees) {
                Console.WriteLine($"{emp.Name} - Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }

        public static void Part3() {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            char startChar = GetInput<char>("Input starting character for the string: ");
            char endChar = GetInput<char>("Input ending character for the string: ");

            var matchingCity = from city in cities
                               where city.StartsWith(startChar.ToString(), StringComparison.OrdinalIgnoreCase) &&
                                     city.EndsWith(endChar.ToString(), StringComparison.OrdinalIgnoreCase)
                               select city;

            Console.WriteLine(matchingCity.Any()
                ? $"The city starting with {startChar} and ending with {endChar} is: {matchingCity.First()}"
                : "No city found with the given criteria.");
        }

        public static void Part4() {
            int[] numbers = { 55, 200, 740, 76, 230, 482, 95 };

            var result = from num in numbers
                         where num > 80
                         select num;

            Console.WriteLine("\nPart 4: Numbers List:");
            foreach (var num in numbers) {
                Console.WriteLine(num);
            }
            Console.WriteLine("\nPart 4: The numbers greater N" +
                "than 80 are:");
            foreach (var num in result) {
                Console.WriteLine(num);
            }
        }

        public static void Part1() {
            int[] numbers = { 2, -1, 3, -3, 10, -200 };

            var positiveNumbers = from num in numbers
                                  where num > 0
                                  select num;

            Console.WriteLine("\nPart 1: Positive numbers:");
            Console.WriteLine(string.Join(", ", positiveNumbers));
        }

        public static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input, typeof(T));
        }
    }
}