using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1C2 {

    delegate bool IsPromotable(Employee employee);

    internal class Employee {
        public int Eid { get; set; }
        public string ?Name { get; set; }
        public int YearsOfExp { get; set; }
        public char Grade { get; set; }
    }
}
