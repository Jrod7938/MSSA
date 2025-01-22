using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2Assignment.Shapes {
    class Circle : Shape {
        public double Radius { get; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
