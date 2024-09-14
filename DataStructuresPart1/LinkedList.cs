using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPart1
{
    public class LinkedList<T>
    {
        public T data { get; set; }
        public LinkedList<T> link { get; set; }

        public LinkedList(T data, LinkedList<T> link)
        {
            this.data = data;
            this.link = link;
        }
    }
}
