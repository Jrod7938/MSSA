using W3D3C3.models;
using W3D3C3.Util;

namespace W3D3C3 {
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.Employees.Add(new Employee() { EmployeeId = 101, FullName = "Lucifer Rodriguez", Salary = 100000, Address = "NYC", Department = Department.Finance});
            Data.Employees.Add(new Employee() { EmployeeId = 102, FullName = "Bruce Wayne", Salary = 200000000, Address = "Gotham", Department = Department.IT});
            Application.Run(new Form1());
        }
    }
}