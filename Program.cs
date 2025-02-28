namespace _6_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 to reverse a string");
            Console.WriteLine("Press 2 to check if a string is a palindrome");
            Console.WriteLine("Press 3 to check if a string is an anagram");

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
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
