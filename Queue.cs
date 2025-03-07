using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class Queue<T>
    {
        LinkedList<T> queue;
        public Queue()
        {

            queue = new LinkedList<T>();

        }

        public void Add(T n)
        {
            queue.AddFirst(n);
        }

        public T Remove() 
        {
            if (queue.Count == 0) return default(T);
            LinkedListNode<T> t = queue.Last;
            queue.RemoveLast();
            return t.Value;
        }

        public int getSize()
        {
            return queue.Count;
        }

        public void PrintQueue()
        {
            foreach (T n in queue)
            {
                Console.WriteLine($"{n} ");
            }
        }

    }

}
