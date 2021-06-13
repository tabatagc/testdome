namespace TestDome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Hobbies
    {
        private readonly Dictionary<string, string[]> hobbies = new Dictionary<string, string[]>();

        public static void Main(string[] args)
        {
            var hobbies = new Hobbies();
            hobbies.Add("Steve", "Fashion", "Piano", "Reading");
            hobbies.Add("Patty", "Drama", "Magic", "Pets");
            hobbies.Add("Chad", "Puzzles", "Pets", "Yoga");

            //Console.WriteLine("The Result: ");
            //Console.WriteLine();
            hobbies.FindAllHobbys("Yoga").ForEach(Console.WriteLine);
        }

        public void Add(string hobby, params string[] hobbies)
        {
            this.hobbies.Add(hobby, hobbies);
        }

        public List<string> FindAllHobbys(string hobby)
        {
            return (from value in hobbies where value.Value.Contains(hobby) select value.Key).ToList();
        }
    }
}
