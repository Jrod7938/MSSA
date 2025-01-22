using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2Assignment.Shapes {
    class Square : Shape {
        public double Side { get; }

        public Square(double side) {
            Side = side;
        }

        public override double Area() {
            return Math.Pow(Side, 2);
        }
    }
}
