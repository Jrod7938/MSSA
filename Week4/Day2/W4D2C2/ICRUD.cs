using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C2 {
    internal interface ICRUD<T> {
        void Create(T entity);
        IList<T> ReadAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
