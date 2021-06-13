namespace TestDome
{
    using System;

    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            if (root.Value == value)
                return true;

            if (value < root.Value)
                return Contains(root.Left, value); //recursive
            else
                return Contains(root.Right, value);
        }

        public static void Main(string[] args)
        {
            var n1 = new Node(1, null, null);
            var n3 = new Node(3, null, null);
            var n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 3));//true
        }
    }

    public class Node
    {
        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
    }
}
