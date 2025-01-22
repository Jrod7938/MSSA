using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2C1 {
    internal class Service {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public bool IsRunning { get; set; }
        
        // constructor
        public Service() {
            ServiceId = 100;
            ServiceName = string.Empty;
            IsRunning = false;
        }

        // overloaded constructor
        public Service(int serviceId) {
            ServiceId = serviceId;
        }

        // overloaded constructor
        public Service(int serviceId, string serviceName, bool isRunning) {
            ServiceId = serviceId;
            ServiceName = serviceName;
            IsRunning = isRunning;
        }

        public static void StartService(int serviceId) {
            // logic
        }

        public static void StartService(string serviceName) {
            // logic
        }
    }
}
