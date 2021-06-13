using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDome
{
    internal enum AllMoves
    {
        none, step, jump
    }

    internal class FrogLeap
    {
        public static List<AllMoves[]> allMoves;

        public static void Frog(Node node, int steps, Stack<AllMoves> stackFrog)
        {
            if (steps > 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        node.Left = new Node(AllMoves.jump);
                        Node nod = node.Left;
                        int recurssive = steps - 2;

                        stackFrog.Push(AllMoves.jump);

                        Frog(nod, recurssive, stackFrog);
                        stackFrog.Pop();
                    }
                    else if (i == 1)
                    {
                        node.Right = new Node(AllMoves.step);
                        Node nod = node.Right;
                        int recurssive = steps - 1;

                        stackFrog.Push(AllMoves.step);
                        Frog(nod, recurssive, stackFrog);

                        stackFrog.Pop();
                    }
                }
            }
            else if (steps == 1)
            {
                node.Center = new Node(AllMoves.step);

                int recurssive = steps - 1;
                stackFrog.Push(AllMoves.step);
                Frog(node, recurssive, stackFrog);
                stackFrog.Pop();
            }
            else if (steps <= 0)
            {
                AllMoves[] a = stackFrog.Select(x => x).ToArray();
                allMoves.Add(a);
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("1.Please, insert the distance to walk: ");

            string input1 = Console.ReadLine();
            int resultout = 0;
            StringBuilder builder = new StringBuilder();
            Stack<AllMoves> pathStack = new Stack<AllMoves>();
            allMoves = new List<AllMoves[]>();
            Node rootNode = new Node(AllMoves.none);

            if (!int.TryParse(input1, out resultout)) return;
            Frog(rootNode, resultout, pathStack);

            if (allMoves.Count <= 0 || allMoves[0].Length <= 0) { Console.WriteLine("Sorry, no distance for Froggie to walk"); return; }

            Console.WriteLine("Result (possible pathes): ");

            foreach (AllMoves[] path in allMoves)
            {
                foreach (AllMoves p in path)
                {
                    builder.Append(p);
                    builder.Append(',');
                }
                builder.Remove(builder.Length - 1, 1);

                Console.WriteLine(builder.ToString());
                builder.Clear();
            }
            Console.WriteLine();
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Frog Leap: ");
            Console.WriteLine();

            while (true) { PrintMenu(); }
        }
    }

    internal class Node
    {
        public Node(AllMoves allmoves)
        {
            this.Value = allmoves;
        }

        private Node()
        {
        }

        public Node Center { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
        public AllMoves Value { get; set; }
    }
}
