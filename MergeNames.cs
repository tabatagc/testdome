namespace TestDome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MergeNames
    {
        public static void Main(string[] args)
        {
            var names1 = new string[] { "Ava", "Emma", "Olivia" };
            var names2 = new string[] { "Olivia", "Sophia", "Emma" };
            Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
        }

        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var list = new List<string>();
            list.AddRange(names1);
            list.AddRange(names2);

            return list.Distinct().ToArray();
        }
    }
}
