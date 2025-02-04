using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C2 {
    internal interface IGenericMath<T> {
        T Add(T x, T y);
        T Multiply(T x, T y);
    }
}
