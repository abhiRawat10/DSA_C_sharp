namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            while (true)
            {
                Console.WriteLine("Press 1 to Add  element in queue");
                Console.WriteLine("Press 2 to Remove element in queue");
                Console.WriteLine("Press 3 to print the queue");
                Console.WriteLine("Press 4 to getSize");
                Console.WriteLine("press 5 to exit");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Enter element to add");
                        int n=Convert.ToInt32(Console.ReadLine());
                        q.Add(n);
                        break;

                    case "2":
                        q.Remove();
                        break;

                    case "3":
                        q.PrintQueue();
                        break;

                    case "4":
                        Console.WriteLine(q.getSize());
                        break;

                    case "5":
                        return;

                        
                }
            }
        }
    }
}
