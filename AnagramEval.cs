namespace TestDome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AnagramEval
    {
        public static List<char> stringOne = new List<char>();
        public static List<char> stringTwo = new List<char>();

        public static bool EvalAnagram(string sstring1, string sstring2)
        {
            if (sstring1.Length != sstring2.Length) { return false; }
            else
            {
                if (!string.IsNullOrEmpty(sstring1))
                    stringOne = ParseStringToCharList(sstring1);

                if (!string.IsNullOrEmpty(sstring2))
                    stringTwo = ParseStringToCharList(sstring2);

                stringOne.Sort();
                stringTwo.Sort();

                for (int x = 0; x < stringOne.Count; x++)
                {
                    if (stringOne[x] != stringTwo[x]) return false;
                }
            }

            return true;
        }

        public static List<char> ParseStringToCharList(string sstring)
        {
            var chars = sstring.ToLower().ToCharArray();

            return chars.ToList();
        }

        private static void Main(string[] args)
        {
            string input1 = String.Empty;
            string input2 = String.Empty;

            Console.WriteLine("For check if two strings are anagrams of each other, please enter first string: ");
            input1 = Console.ReadLine();

            Console.WriteLine("Please enter with the second string");
            input2 = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ara Anagram: " + EvalAnagram(input1, input2).ToString());
            Console.ReadLine();
        }
    }
}
