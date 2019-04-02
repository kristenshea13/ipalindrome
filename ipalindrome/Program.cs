using System;

namespace ipalindrome
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Write a C# program to check if a given string is a palindrome or not. Go to the editor
            //Sample Example:
            //For 'aaa' the output should be true
            //For 'abcd' the output should be false

            Console.Write("Please type out a string of letters: ");
            string x = Console.ReadLine().ToLower();
            bool answer = Palindrome(x);

            if (answer)
            {
                Console.WriteLine("Yes, this is a palindrome.");
            }
            else
            {
                Console.WriteLine("No, this is not a palindrome.");
            }

            Console.ReadLine();
        }

        private static bool Palindrome(string x)
        {
            char[] y = x.ToCharArray();
            Array.Reverse(y);

            return new string(y).Equals(x);
        }
    }
}