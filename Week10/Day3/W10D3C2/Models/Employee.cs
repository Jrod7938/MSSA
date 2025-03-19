using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D3C2.Models {
    public class Employee {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmpId { get; set; } // PK
        public string Name { get; set; }
        public double Salary { get; set; }
        public int DepartmentID { get; set; } // FK
        public virtual Department Department { get; set; } // relationship
    }
}
