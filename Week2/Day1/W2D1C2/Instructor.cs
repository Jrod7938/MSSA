using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C2 {
    internal class Instructor : Person {
        public double Salary { get; set; }

        public override void DoWork() {
            Console.WriteLine("I teach C# to students.");
        }

        public override void FollowSchedule() {
            Console.WriteLine("I'm teaching a virtual classroom from 8am to 4pm PST.");
        }
    }
}
