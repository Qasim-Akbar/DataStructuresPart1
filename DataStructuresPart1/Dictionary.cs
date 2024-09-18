using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPart1
{
    internal class Dictionary : DictionaryBase
    {
        public Dictionary() { }

        public void Add(string key, object value) { 
            base.InnerHashtable.Add(key, value);
        }

        public object Item(string key)
        {
            return base.InnerHashtable[key];
        }

        public void Remove(string key)
        {
            base.InnerHashtable.Remove(key);
        }
    }
}
