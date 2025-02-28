namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to flip coin n times");
            Console.WriteLine("Press 2 to find calculate  Leap year");
            Console.WriteLine("Press 3 to print table of 2");
            Console.WriteLine("Press 4 to find max subarray sum using Kadane's algorithm");
            Console.WriteLine("Press 5 to find missing number in array");
            Console.WriteLine("Press 6 to move zeroes to end of array");
            Console.WriteLine("Press 7 to find intersection of 2 arrays");
            Console.WriteLine("Press 8 to find pair with given sum in array");

            switch (Console.ReadLine())
            {
                case "1":
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.entry();
                    break;

                case "2":
                    //this is without using array
                    LeapYear leapYear = new LeapYear();
                    leapYear.Entry();
                    break;

                case "3":
                    //this is without using array
                    PowerOf2Table powerOf2Table = new PowerOf2Table();
                    powerOf2Table.Entry();
                    break;

                case "4":
                    MaxSubarraySumKadane maxSubarraySumKadane = new MaxSubarraySumKadane();
                    maxSubarraySumKadane.Entry();
                    break;

                case "5":
                    MissingNumber missingNumber = new MissingNumber();
                    missingNumber.entry();
                    break;

                case "6":
                    MoveZeroesToEnd moveZeroesToEnd = new MoveZeroesToEnd();
                    moveZeroesToEnd.Entry();
                    break;

                case "7":
                    IntersectionOf2Array obj = new IntersectionOf2Array();
                    obj.Entry();
                    break;

                case "8" :
                    PairSum pairSum = new PairSum();
                    pairSum.Entry();
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
