using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W11D1Assignment11._1.Data {
    public class Book {
        public string ISBN { get; set; } // Primary Key
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
