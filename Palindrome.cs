using System;

namespace TestDome
{
    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            string x = "";

            for (int i = 0; i < word.Length; i++)
            {
                x += word.Substring(word.Length - i - 1, 1);
            }

            return word.ToLower() == x.ToLower();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
            Console.ReadKey();
        }
    }
}
