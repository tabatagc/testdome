namespace TestDome
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        public Path(string value)
        {
            this.current = value;
        }

        public string current { get; private set; }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. DOS path");
                string input1 = Console.ReadLine();

                Console.WriteLine("2. CD DOS command path");
                string input2 = Console.ReadLine();

                Path path_ = new Path(input1);
                string result = path_.Cd(input2);

                Console.WriteLine();
                Console.WriteLine("You are in path " + result);

                Console.WriteLine();
                Console.WriteLine("the end");
            }
        }

        public string Cd(string newPath)
        {
            if (newPath.StartsWith("/"))
            {
                current = newPath;
            }
            else if (newPath.Contains(".."))
            {
                var pathList = new LinkedList<string>(current.Split('/'));
                var newPathList = newPath.Split('/');

                foreach (var item in newPathList)
                {
                    if (item == "..")
                        if (pathList.Count > 0) pathList.RemoveLast();
                        else
                            pathList.AddLast(item);
                }

                current = string.Join("/", pathList);

                if (!current.StartsWith("/"))
                    current = "/" + current;
            }
            else
            {
                current += "/" + newPath;
            }

            return current;
        }
    }
}
