using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4C2 {
    public class Employee {
        static int count = 0; // shares count with all employee objects

        private int id;
        public int Id {
            get { return id; }
        }
        public string Name { get; set; }
        public float HourlyRate { get; set; }
        public float WeeklyHours { get; set; }
        private decimal salary;
        public decimal Salary {
            get { return salary; }
        }


        public Employee() {
            count++;
            id = count;
        }

        private void Deductions() {
            HourlyRate = HourlyRate - (HourlyRate * 5) / 100;
        }

        public decimal CalculateSalary() {
            Deductions();
            salary = Convert.ToDecimal(HourlyRate * WeeklyHours * 2);
            return salary;
        }

    }
}
