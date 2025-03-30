using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest.Models {
    public class LoginResponse {
        public bool error { get; set; }
        public string message { get; set; }
        public string session { get; set; }
    }
}
