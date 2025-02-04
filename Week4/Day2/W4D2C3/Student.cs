using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C3 {
    internal class Student : IComparable<Student>{
        public int Id { get; set; }
        public string Name { get; set; }
        public float Gpa { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other) {
            return this.Name.CompareTo(other.Name);
        }
    }
}
