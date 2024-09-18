using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPart1
{
    internal class Queue
    {
        private ArrayList pqueue;
        public Queue()
        {
            pqueue = new ArrayList();
        }

        public void EnQueue(object item)
        {
            pqueue.Add(item);
        }

        public object DeQueue()
        {
            object obj = pqueue[0];
            pqueue.RemoveAt(0);
            return obj;
        }

        public object Peek()
        {
            return pqueue[0];
        }

        public void ClearQueue()
        {
            pqueue.Clear();
        }

        public int Count()
        {
            return pqueue.Count;
        }
    }
}
