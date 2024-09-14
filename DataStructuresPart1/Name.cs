using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructuresPart1
{
    internal struct Name
    {
        public string fname { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }

        public Name(string fname, string mName, string lName)
        {
            this.fname = fname;
            this.mName = mName;
            this.lName = lName;
        }

        public override string ToString()
        {
            return String.Format($"{fname}, {mName}, {lName}");
        }

        public string Initials()
        {
            return String.Format($"{fname.Substring(0,1)}{mName.Substring(0, 1)}{lName.Substring(0, 1)}");
        }
    }
}
