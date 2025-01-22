using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2Assignment {
    abstract class Shape {
        public static int currentID = 1;

        public int ID { get; }
        public string Name { get; }
        public string Color = string.Empty;

        public Shape() {
            ID = currentID++;
            Name = GetType().Name + ID;
        }

        public abstract double Area();

    }
}
