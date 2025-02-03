namespace W4D1C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Eid = 1, Name = "John", YearsOfExp = 5, Grade = 'A' });
            employees.Add(new Employee() { Eid = 2, Name = "Smith", YearsOfExp = 2, Grade = 'B' });
            employees.Add(new Employee() { Eid = 3, Name = "Peter", YearsOfExp = 7, Grade = 'A' });
            employees.Add(new Employee() { Eid = 4, Name = "Sam", YearsOfExp = 5, Grade = 'B' });
            employees.Add(new Employee() { Eid = 5, Name = "David", YearsOfExp = 3, Grade = 'C' });

            Console.WriteLine("Employee List");
            foreach(Employee employee in employees) {
                Console.WriteLine($"{employee.Name}, {employee.Grade}, {employee.YearsOfExp}");
            }

            Console.WriteLine("Employees that can be promoted by Grade");
            PromoteEmployee(employees, PromotableByGrade);
            Console.WriteLine("Employees that can be promoted by Experience");
            PromoteEmployee(employees, PromotableByExperience);
        }

        static void PromoteEmployee(List<Employee> employees, IsPromotable isPromotable) {
            foreach(Employee employee in employees) {
                if (isPromotable(employee)) {
                    Console.WriteLine($"{employee.Name} can be promoted");
                }
            }
        }

        static bool PromotableByGrade(Employee employee) {
            if (employee.Grade == 'A') {
                return true;
            }
            return false;
        }

        static bool PromotableByExperience(Employee employee) {
            if (employee.YearsOfExp >= 5) return true;
            return false;
        }
    }
}
