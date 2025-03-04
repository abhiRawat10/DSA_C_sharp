using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class Stack<T>
    {
        LinkedList<T> stack = new LinkedList<T>();
        int Size = 0;
        T top;

        public void Push(T item)
        {
            stack.AddFirst(item);
            Size++;
            top=item;
        }

        public void Pop()
        {
            if (Size<= 0) return;

            stack.RemoveFirst();
            Size--;

            if (Size == 0)
            {
                top = default(T);
            }
            else
            {
                top = stack.First.Value;
            }
        }

        public int getSize()
        {
            return Size;
        }

        public void printStack()
        {
            foreach (T item in stack)
            {
                Console.WriteLine(item+" ");
            }
        }




    }
}
