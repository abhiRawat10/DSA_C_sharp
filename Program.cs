namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to reverse a string");
            Console.WriteLine("Press 2 to check if a string is a palindrome");
            Console.WriteLine("Press 3 to check if a string is an anagram");
            Console.WriteLine("Press 4 to find first unique char in a string");
            Console.WriteLine("Press 5 to find longest non repeating substring");
            Console.WriteLine("Press 6 to convert Roman to Integer");
            Console.WriteLine("Press 7 to compress a string");

            string? input = Console.ReadLine();
            
            switch(input)
            {
                case "1":
                    ReverseString reverseString = new ReverseString();
                    reverseString.Entry();
                    break;

                case "2":
                    PalindromeString palindromeString = new PalindromeString();
                    palindromeString.Entry();
                    break;

                case "3":
                    Anagram anagram = new Anagram();
                    anagram.Entry();
                    break;

                case "4":
                    FirstUniqueChar firstUniqueChar = new FirstUniqueChar();
                    firstUniqueChar.Entry();
                    break;

                case "5":
                    LongestNonRepeatingSbstring longestNonRepeatingSbstring = new LongestNonRepeatingSbstring();
                    longestNonRepeatingSbstring.Entry();
                    break;

                case "6":
                    RomanToInt romanToInt = new RomanToInt();
                    romanToInt.Entry();
                    break;

                case "7":
                    StringCompresseion stringCompresseion = new StringCompresseion();
                    stringCompresseion.Entry();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
