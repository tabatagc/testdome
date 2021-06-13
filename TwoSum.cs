namespace TestDome
{
    using System;
    using System.Collections.Generic;

    public class TwoSum
    {
        public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
        {
            for (var i = 0; i < list.Count; i++)
            {
                for (var j = i + 1; j < list.Count; j++)
                {
                    var trialsum = list[i] + list[j];
                    if (trialsum == sum)
                    {
                        return new Tuple<int, int>(i, j);
                    }
                }
            }

            return null;
        }

        public static Tuple<int, int> FindTwoSum2(IList<int> list, int sum) //Stolen from: https://stackoverflow.com/questions/36506164/find-two-sum-function-in-c-sharp
        {
            var hs = new HashSet<int>();
            for (var i = 0; i < list.Count; i++)
            {
                var needed = sum - list[i];
                if (hs.Contains(needed))
                {
                    return Tuple.Create(list.IndexOf(needed), i);
                }
                hs.Add(list[i]);
            }

            return null;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Two Sums");
            Console.WriteLine();

            Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
            if (indices != null)
            {
                Console.WriteLine(indices.Item1 + " " + indices.Item2);
            }
        }
    }
}
