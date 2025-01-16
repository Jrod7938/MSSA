using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4C1 {
    public struct PostalAddress {

        public PostalAddress(int houseNumber, string streetName, string city, string state, int zipCode) {
            HouseNumber = houseNumber;
            StreetName = streetName;
            City = city;

            this.state = state;
            this.zipCode = zipCode;
        }

        public PostalAddress(int houseNumber) {
            HouseNumber = houseNumber;
            StreetName = string.Empty;
            City = string.Empty;
            this.zipCode = 00000;
            this.state = string.Empty;
        }


        public int HouseNumber { get; set; } // get and set are accessors for the property
        public string StreetName { get; set; }
        public string City { get; set; }
        private int zipCode;
        public int ZipCode {
            get { return zipCode; }
            set {
                if(value.ToString().Length == 5) {
                    zipCode = value;
                }
            }
        }
        private string state;
        public string State {
            get {
                if(ZipCode.ToString().StartsWith("111")) {
                    state = "NY";
                }
                return state;
            }
        }
    }
}
