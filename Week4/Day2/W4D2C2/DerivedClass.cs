using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C2 {
    internal class DerivedClass : AbstractClass {
        public override void AbstractMethod() {
            throw new NotImplementedException();
        }

        public override void VirtualMethod() {
            base.VirtualMethod();
        }
    }
}
