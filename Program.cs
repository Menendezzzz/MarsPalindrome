using System;

namespace PalindromeDetector
{
    internal class Program
    {
        static void Main()
        {
            var checker = new PalindromeChecker();

            Console.WriteLine("=== Palindrome Detector ===");
            Console.Write("Enter text or 'exit' to quit: ");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                bool isPalindrome = checker.IsPalindrome(input);
                string result = isPalindrome ? "Palindrome" : "Not a palindrome";
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}