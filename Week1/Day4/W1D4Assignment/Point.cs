using System;

namespace W1D4Assignment {
    public struct Point {
        public int x { get; }
        public int y { get; }

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public static void Compare(Point point1, Point point2) {
            if (point1.x > point2.x) {
                Console.WriteLine($"Point1 x:{point1.x} is more than Point2 x:{point2.x}, it is to the right.");
            } else if(point1.x < point2.x) {
                Console.WriteLine($"Point1 x:{point1.x} is less than Point2 x:{point2.x}, it is to the left.");
            } else {
                Console.WriteLine($"Point1 x: {point1.x} is the same as Point2 x: {point2.x}");
            }
        }
    }
}
