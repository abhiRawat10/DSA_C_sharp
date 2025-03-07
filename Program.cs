using System;

namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the size of the array (or 'q' to quit): ");
                string input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                int size = int.Parse(input);
                int[] arr = new int[size];

                Console.WriteLine("Enter the elements of the array:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Choose a sorting algorithm:");
                Console.WriteLine("1. Merge Sort");
                Console.WriteLine("2. Bubble Sort");
                Console.WriteLine("3. Insertion Sort");
                Console.WriteLine("4. Selection Sort");
                Console.Write("Enter your choice (1-4) or 'q' to quit: ");
                input = Console.ReadLine();
                if (input.ToLower() == "q")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }

                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        MergeSort.Divide(arr, 0, arr.Length - 1);
                        break;
                    case 2:
                        BubbleSort.Sort(arr);
                        break;
                    case 3:
                        InsertionSort.Sort(arr);
                        break;
                    case 4:
                        SelectionSort.Sort(arr);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        continue;
                }

                Console.WriteLine("Sorted array:");
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.Write("Do you want to exit? (y/n): ");
                string exitChoice = Console.ReadLine().ToLower();
                if (exitChoice == "y")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
            }
        }
    }
}
