using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5D1C1 {
    // Immutable Object
    internal class Document {
        private string name;
        private string content;
        public Document(string name, string content) {
            this.name = name;
            this.content = content;
        }
        // readonly - immutable
        public string Name { get { return name; } }
        public string Content {  get { return content; } }
    }
}
