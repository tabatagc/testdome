namespace TestDome
{
    using System;

    public class LongestRun
    {
        public static int IndexOfLongestRun(string sstring)
        {
            var currentRunLength = 0;
            var currentRunIndex = 0;
            var longestRunLength = 0;
            var longestRunIndex = 0;

            for (var i = 1; i < sstring.Length; i++)
            {
                var currentCharacter = sstring[i];
                var previousCharacter = sstring[i - 1];

                if (previousCharacter == currentCharacter)
                    currentRunLength++;
                else
                {
                    if (longestRunLength < currentRunLength)
                    {
                        longestRunLength = currentRunLength;
                        longestRunIndex = currentRunIndex;
                    }

                    currentRunLength = 0;
                    currentRunIndex = i;
                }
            }

            if (longestRunLength < currentRunLength)
            {
                longestRunLength = currentRunLength;
                longestRunIndex = currentRunIndex;
            }

            return longestRunIndex;
        }

        private static void Main(string[] args)
        {
            string input1 = String.Empty;

            Console.WriteLine("Please, enter with the string");
            input1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Longest Run Letter Index is: " + IndexOfLongestRun(input1).ToString());
            Console.WriteLine();
        }
    }
}
