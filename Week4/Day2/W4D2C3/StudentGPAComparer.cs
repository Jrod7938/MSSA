using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C3 {
    internal class StudentGPAComparer : IComparer<Student> {
        public int Compare(Student? x, Student? y) {
            return x.Gpa.CompareTo(y.Gpa);
        }
    }
}
