using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D3C3.models {
    internal class Employee : Person {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }

    }
}
