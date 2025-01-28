using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D2Assignment3._2 {
    internal class Circle {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public double GetArea() {
            return Math.PI * Radius * Radius;
        }

        public static double operator +(Circle circle1, Circle circle2) {
            return circle1.GetArea() + circle2.GetArea();
        }

        public static double operator -(Circle circle1, Circle circle2) {
            return Math.Abs(circle1.GetArea() - circle2.GetArea());
        }
    }
}
