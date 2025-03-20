using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W10D3C2.Data;
using W10D3C2.Models;

namespace W10D3C2.Services {
    public class CRUD {
        public void AddRecord(Employee employee) {
            Records.employeeContext.Employees.Add(employee); // added to local db
            Records.employeeContext.SaveChanges();
        }

        public void DeleteRecord(int eid) {
            var emp = Records.employeeContext.Employees.Find(eid);
            if (emp != null) {
                Records.employeeContext.Employees.Remove(emp);
            }
            Records.employeeContext.SaveChanges();
        }

        public void UpdateRecord(int id, Employee employee) {
            var empToupdate = Records.employeeContext.Employees.Find(id);

            if(empToupdate != null) {
                empToupdate.EmpId = employee.EmpId;
                empToupdate.Name = employee.Name;
                empToupdate.Salary = employee.Salary;
                empToupdate.DepartmentID = employee.DepartmentID;
            }
        }

        public int GetMaxId() {
            return Records.employeeContext.Employees.Max(e => e.EmpId);
        }

        public ICollection<Employee> GetEmployees() {
            return Records.employeeContext.Employees.ToList();
        }
        public ICollection<Department> GetDepartments() {
            return Records.employeeContext.Departments.ToList();
        }

        public Employee FindEmployee(int id) {
            return Records.employeeContext.Employees.Find(id);
        }
    }
}
