namespace TestDome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AllAnagrams
    {
        private static List<char[]> allAnagramsList = new List<char[]>();

        private static void getAllAnagrams(string sstring, Stack<char> stack, ref Node node)
        {
            if (sstring.Length <= 0)
            {
                allAnagramsList.Add(stack.Select(x => x).ToArray());
            }

            for (int i = 0; i < sstring.Length; i++)
            {
                if (node != null && !node.nodeList.Exists(x => x.value == sstring[i]))
                {
                    Node newnode = new Node();

                    newnode.value = sstring[i];
                    stack.Push(sstring[i]);

                    node.nodeList.Add(newnode);

                    string temp = sstring.Remove(i, 1);

                    getAllAnagrams(temp, stack, ref newnode);
                    stack.Pop();
                }
            }
        }

        private static void Main(string[] args)
        {
            string inputString = String.Empty;
            Stack<char> stack = new Stack<char>();

            Console.WriteLine("Find all Anagrams of a string. Please, enter first string ");
            inputString = Console.ReadLine();

            Console.WriteLine();

            Node node = new Node();
            getAllAnagrams(inputString, stack, ref node);

            Console.WriteLine("All Angrams are:");

            int i = 0;
            foreach (char[] ch in allAnagramsList)
            {
                i++;
                Console.WriteLine(i + ". " + string.Join("", ch));
            }
            Console.ReadLine();
        }

        public class Node
        {
            public Node()
            {
                nodeList = new List<Node>();
            }

            public List<Node> nodeList { get; set; }
            public char value { get; set; }
        }
    }
}
