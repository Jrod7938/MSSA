using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1Assignment.Part1 {
    abstract class Ammunition {
        private double velocity;
        public double Velocity {  get { return velocity; } set { velocity = value; } }
        private double weight;
        public double Weight {  get { return weight;  } set { if (value >= 0) weight = value; } }
    }
}
