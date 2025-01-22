using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2C1 {
    internal class B : A {
        public string Name { get; set; }
        public override void Method1() {
            Console.WriteLine("In method1 from class B");
        }

        public void Method2() {

        }
    }
}
