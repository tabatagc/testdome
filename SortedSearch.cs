namespace TestDome
{
    using System;
    using System.Collections.Generic;

    public class SortedSearch
    {
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {
            var result = new Dictionary<int, bool>();

            foreach (var number in sortedArray)
            {
                if (number < lessThan)
                    result.Add(number, false);
            }

            return result.Count;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7 }, 4)); //2
        }
    }
}
