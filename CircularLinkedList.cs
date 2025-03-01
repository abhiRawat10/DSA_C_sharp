using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class CircularLinkedList
    {
        public Node head;
        public Node tail;
        public int count;
        public CircularLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AddFirst(int data)
        {
            Node toAdd = new Node(data);
            if (head == null)
            {
                head = toAdd;
                tail = toAdd;
                head.next = head;
                head.Prev = head;
            }
            else
            {
                toAdd.next = head;
                head.Prev = toAdd;

                head = toAdd;

                head.Prev = tail;
                tail.next = head;
            }
            count++;
        }
        public void AddLast(int data)
        {
            Node toAdd = new Node(data);
            if (head == null)
            {
                head = toAdd;
                tail = toAdd;
                head.next = head;
                head.Prev = head;
            }
            else
            {
                tail.next = toAdd;
                toAdd.Prev = tail;

                tail = toAdd;

                head.Prev = tail;
                tail.next = head;
            }
            count++;
        }
        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.Prev = tail;
                tail.next = head;
            }
            count--;
        }
        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.Prev;
                tail.next = head;
                head.Prev = tail;
            }
            count--;
        }

        public void AddAt(int index, int data)
        {
            if (index < 0 || index > count)
            {
                return;
            }
            if (index == 0)
            {
                AddFirst(data);
                return;
            }
            if (index == count)
            {
                AddLast(data);
                return;
            }
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            Node toAdd = new Node(data);
            toAdd.next = current.next;
            current.next.Prev = toAdd;
            current.next = toAdd;
            toAdd.Prev = current;
            count++;
        }


        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                return;
            }
            if (index == 0)
            {
                RemoveFirst();
                return;
            }
            if (index == count - 1)
            {
                RemoveLast();
                return;
            }
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            current.next = current.next.next;
            current.next.Prev = current;
            count--;
        }   
        public void Print()
        {
            Node current = head;
            do
            {
                Console.WriteLine(current.data);
                current = current.next;
            } while (current != head);
        }
    }
}
