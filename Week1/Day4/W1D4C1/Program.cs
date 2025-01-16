using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4C1 {
    internal class Program {
        static void Main(string[] args) {
            PostalAddress address = new PostalAddress();
            address.HouseNumber = 3436;
            address.StreetName = "S. 7th St.";
            address.City = "Seattle";
            address.ZipCode = 98144;

            Console.WriteLine($"Address is {address.HouseNumber} {address.StreetName} {address.City}, {address.ZipCode}.");

            PostalAddress address2 = new PostalAddress(2207, "Forest Hill Dr.", "Queens", "NY", 11140);
            PostalAddress address3 = new PostalAddress(2207);

        }
    }
}
