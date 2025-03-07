namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the size of the array: ");

                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                Console.WriteLine("Enter the elements of the array: ");
                for (int i = 0; i < n; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Enter the element to search: ");
                int el = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("1. Linear Search");
                Console.WriteLine("2. Binary Search");
                Console.WriteLine("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LinearSearch(arr, el);
                        break;
                    case 2:
                        BinarySearch(arr, el);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? (Y/N)");
                string ch = Console.ReadLine();
                if (ch == "N" || ch == "n")
                {
                    break;
                }
            }
        }
        public static void LinearSearch(int[] arr,int el)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == el)
                {
                    Console.WriteLine("Element found at index: " + i);
                    return;
                }
            }
            Console.WriteLine("Element not found");
        }
        public static void BinarySearch(int[] arr, int el)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == el)
                {
                    Console.WriteLine("Element found at index: " + mid);
                    return;
                }
                else if (arr[mid] < el)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            Console.WriteLine("Element not found");
        }
    }
}
