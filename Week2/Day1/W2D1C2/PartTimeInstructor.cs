using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C2 {
    internal class PartTimeInstructor : Instructor {
        public override void FollowSchedule() {
            Console.WriteLine("I conduct Labs from 8am to 12pm PST.");
        }

        public override void DoWork() {
            Console.WriteLine("I grade the student's lab assignments.");
        }
    }
}
