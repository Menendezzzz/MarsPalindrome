using System;
using System.Linq;

namespace PalindromeDetector
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            // Keep letters and numbers, make lowercase
            string cleaned = new string(text
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            // Reverse the string
            string reversed = new string(cleaned.Reverse().ToArray());

            // Check if same forwards and backwards
            return cleaned == reversed;
        }
    }
}