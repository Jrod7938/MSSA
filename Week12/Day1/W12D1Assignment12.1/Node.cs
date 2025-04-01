using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D1Assignment12._1 {
    public class Node {
        public int val { get; set; }
        public Node? next { get; set; }

        public Node(int val, Node? next) {
            this.val = val;
            this.next = next;
        }
    }
}
