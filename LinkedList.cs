using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_DSA
{
    internal class LinkedList
    {
        public Node head;
        public Node tail;
        public int count;
        public LinkedList()
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
            }
            else
            {
                toAdd.next = head;
                head.Prev = toAdd;
                head = toAdd;
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
            }
            else
            {
                tail.next = toAdd;
                toAdd.Prev = tail;
                tail = toAdd;
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
                head.Prev = null;
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
                tail.next = null;
            }
            count--;
        }

        public void insertAt(int index, int data)
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
            Node toAdd = new Node(data);
            Node current = head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            toAdd.next = current.next;
            toAdd.Prev = current;
            current.next.Prev = toAdd;
            current.next = toAdd;
            count++;
        }

        public Node RemoveAt(int index)
        {
            if (index < 0 || index >= count)
            {
                return null;
            }
            Node current = head;
            if (index == 0)
            {
                RemoveFirst();
                return current;
            }
            if (index == count - 1)
            {
                RemoveLast();
                return current;
            }
            for (int i = 0; i < index; i++)
            {
                current = current.next;
            }
            current.Prev.next = current.next;
            current.next.Prev = current.Prev;
            count--;
            return current;

        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
    internal class Node
    {
        public int data;
        public Node next;
        public Node Prev;

        public Node(int d)
        {
            data = d;
            next = null;
            Prev = null;
        }
    }
}
