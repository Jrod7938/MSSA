using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C2 {
    internal class DataOperations : ICRUD<Student> {
        static List<Student> Students = new List<Student>();
        public void Create(Student entity) {
            Students.Add(entity);
        }

        public void Delete(Student entity) {
            Students.Remove(entity);
        }

        public IList<Student> ReadAll() {
            return Students;
        }

        public void Update(Student entity) {
            throw new NotImplementedException();
        }
    }
}
