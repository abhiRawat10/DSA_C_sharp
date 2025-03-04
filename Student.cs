using System;
using System.Net;


namespace _6_DSA {


    class Student
    {
        public string Name;
        public int Age;
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
    class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node<T> Prev;

        public Node(T value)
        {
            Data = value;
            Next = null;
            Prev = null;
        }
    }

    // Doubly Linked List class
    class StudentLl<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public StudentLl()
        {
            head = null;
            tail = null;
        }

        // Insert at the end
        public void Add(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        // Display list forward
        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }


        // Delete a node 
        public void Remove(string value)
        {
            if (head == null) return;

            // Check the head node separately
            if (head.Data is Student student && student.Name.Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                head = head.Next;
                if (head != null) head.Prev = null;
                else tail = null; // List is empty
                return;
            }

            Node<T> temp = head;
            while (temp != null)
            {
                // Ensure temp.Data is a Student before accessing Name
                if (temp.Data is Student s && s.Name.Equals(value, StringComparison.OrdinalIgnoreCase))
                {
                    break; // Found the matching node, exit loop
                }
                temp = temp.Next;
            }

            if (temp == null) return; // Value not found

            // Remove the node
            if (temp.Next != null) temp.Next.Prev = temp.Prev;
            if (temp == tail) tail = temp.Prev; // If deleting the last node, update tail

            if (temp.Prev != null) temp.Prev.Next = temp.Next; // Connect previous node to the next node
        }

    }

}


