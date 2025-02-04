using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2Assignment4._1._2 {
    internal class HistoryEntry {
        public string Expression { get; set; }

        public HistoryEntry(string expression) {
            Expression = expression;
            Maths.History.Add(this);
        }
    }
}
