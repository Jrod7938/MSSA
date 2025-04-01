using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W12D1C1
{
    [Serializable]
    [Obsolete("This class will be not available in future release")]
   
    internal class Class1
    {
        [NonSerialized]
        public string Name;
    }

    [AttributeUsage(AttributeTargets.All)]
    public class  DeveloperInfoAttribute:Attribute
    {
        private string name;
        private string email;
        public string Name
        {
            get { return name; }
        }
        public string Email
        { get { return email; } }
        public DeveloperInfoAttribute(string name, string email)
        {
            this.name = name;   
            this.email = email;
        }
    }
}
