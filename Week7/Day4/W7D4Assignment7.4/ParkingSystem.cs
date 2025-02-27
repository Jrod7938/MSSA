using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7D4Assignment7._4 {
    internal class ParkingSystem {
        private int[] spaces;
        public ParkingSystem(int big, int medium, int small) {
            spaces = new int[] { big, medium, small };
        }
        public bool AddCar(int carType) {
            if (spaces[carType - 1] > 0) {
                spaces[carType - 1]--;
                return true;
            }
            return false;
        }
    }
}
