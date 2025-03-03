namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Press 1 for LinkedList");
            Console.WriteLine("Press 2 for CircularLinkedList");
            Console.WriteLine("Press 3 for StudentLinkedList");

            string s1 = Console.ReadLine();
            switch (s1)
            {
                case "1":
                    Ll();
                    break;
                case "2":
                    Cll();
                    break;
                case "3":
                    StuLl();
                    break;
            }
        }


        static public void StuLl()
        {
            StudentLl<Student> list = new StudentLl<Student>();
            list.Add(new Student("abc", 20));
            list.Add(new Student("def", 21));
            list.Add(new Student("ghi", 22));

            while (true)
            {
                Console.WriteLine("Press 1 to Add Student");
                Console.WriteLine("Press 2 to Remove Student");
                Console.WriteLine("Press 3 to Print");
                string s = Console.ReadLine();
                Console.Clear();
                switch (s)
                {
                    case "1":
                        Console.WriteLine("Enter the name of the student");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the age of the student");
                        int age = Convert.ToInt32(Console.ReadLine());
                        list.Add(new(name, age));
                        break;
                    case "2":
                        Console.WriteLine("Enter the name of the student to remove");
                        string name1 = Console.ReadLine();
                        list.Remove(name1);
                        break;
                    case "3":
                        list.Display();
                        break;
                    case "4":
                        return;
                }
                Console.WriteLine("Press q to exit or any other key to continue");
                if (Console.ReadLine() == "q")
                {
                    break;
                }
            }
        }

            static public void Ll()
        {
            LinkedList list = new LinkedList();
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddFirst(4);
            list.AddFirst(5);
            while (true)
            {
                Console.WriteLine("Press 1 to Add First");
                Console.WriteLine("Press 2 to Add Last");
                Console.WriteLine("Press 3 to Remove First");
                Console.WriteLine("Press 4 to Remove Last");
                Console.WriteLine("Press 5 to Print");
                string s = Console.ReadLine();
                Console.Clear();
                switch (s)
                {
                    case "1":
                        Console.WriteLine("Enter the number to addFirst");
                        int n = Convert.ToInt32(Console.ReadLine());
                        list.AddFirst(n);
                        break;
                    case "2":
                        Console.WriteLine("Enter the number to addLast");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        list.AddLast(n1);
                        break;
                    case "3":
                        list.RemoveFirst();
                        break;
                    case "4":
                        list.RemoveLast();
                        break;
                    case "5":
                        list.Print();
                        break;
                    case "6":
                        return;
                }
                Console.WriteLine("Press q to exit or any other key to continue");
                if (Console.ReadLine() == "q")
                {
                    break;
                }
            }
        }

        static public void Cll()
        {
            CircularLinkedList clist = new CircularLinkedList();
            clist.AddFirst(1);
            clist.AddFirst(2);
            clist.AddFirst(3);
            clist.AddFirst(4);
            clist.AddFirst(5);
            while (true)
            {
                Console.WriteLine("Press 1 to Add First");
                Console.WriteLine("Press 2 to Add Last");
                Console.WriteLine("Press 3 to Remove First");
                Console.WriteLine("Press 4 to Remove Last");
                Console.WriteLine("Press 5 to Print");
                string s = Console.ReadLine();
                Console.Clear();
                switch (s)
                {
                    case "1":
                        Console.WriteLine("Enter the number to addFirst");
                        int n = Convert.ToInt32(Console.ReadLine());
                        clist.AddFirst(n);
                        break;
                    case "2":
                        Console.WriteLine("Enter the number to addLast");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        clist.AddLast(n1);
                        break;
                    case "3":
                        clist.RemoveFirst();
                        break;
                    case "4":
                        clist.RemoveLast();
                        break;
                    case "5":
                        clist.Print();
                        break;
                    case "6":
                        return;
                }
                Console.WriteLine("Press q to exit or any other key to continue");
                if (Console.ReadLine() == "q")
                {
                    break;
                }
            }
        }
    }
}
