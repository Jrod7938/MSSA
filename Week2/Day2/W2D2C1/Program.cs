using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2C1 {
    internal class Program {
        static void Main(string[] args) {
            A objA = new A();
            objA.Method1();
            B objB = new B();
            objB.Method1();

            A obj1 = new B(); // cross referencing
            obj1.Method1();
            obj1.ID = 9; // properties of A
            // obj1.Name doesn't work since it is A
            // obj1.Method2() doesn't work. Only access to overriden methods
            OutputFormatter.DisplayName("Jc"); // static method
            OutputFormatter.DisplayName("Jc", "Rodriguez");


            Service firstService = new Service();
            Service secondService = new Service(23, "API", false);

            Service.StartService(secondService.ServiceName);
        }
    }
}
