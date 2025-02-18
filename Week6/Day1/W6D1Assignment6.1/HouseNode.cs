using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6D1Assignment6._1 {
    internal class HouseNode {

        public House House;
        public HouseNode Next;
        public int HouseNumber;
        public string Address;

        public HouseNode(House house, int houseNumber, string address) {
            House = house;
            Next = null;
            HouseNumber = houseNumber;
            Address = address;
        }

        public HouseNode(House house, int houseNumber, string address, HouseNode next) {
            House = house;
            Next = next;
            HouseNumber = houseNumber;
            Address = address;
        }

        override public string ToString() {
            return "House Type: " + House.ToString() + "\nHouse #: " + HouseNumber + "\nHouse Address: " + Address;
        }
    }
}
