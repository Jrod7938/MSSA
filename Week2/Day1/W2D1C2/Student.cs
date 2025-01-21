using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C2 {
    internal class Student : Person {
        public float GPA { get; set; }

        // virtual override
        override public void DoWork() {
            // base.DoWork(); base class implementation
            Console.WriteLine("I do some C# homework.");
        }

        // abstract override
        public override void FollowSchedule() {
            Console.WriteLine("I'm in a virtual classroom from 8am to 4pm PST.");

        }
    }
}
