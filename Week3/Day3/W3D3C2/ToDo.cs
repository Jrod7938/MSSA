using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D3C2 {
    internal class ToDo {
        public int TaskId { get; set; }
        public string ?Description { get; set; } // ? can hold null values
        public float EstimatedHours { get; set; }
        public Status TaskStatus { get; set; }


    }
}
