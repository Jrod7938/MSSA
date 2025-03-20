using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D3C2.Models {
    public class Department {
        public int DepartmentID { get; set; }
        public string? DepartmentName { get; set; }
        public virtual ObservableCollectionListSource<Employee> Employees { get; set; }

        public override string ToString() {
            return DepartmentName;
        }
    }
}
