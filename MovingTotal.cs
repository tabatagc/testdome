namespace TestDome
{
    using System;
    using System.Collections.Generic;

    public class MovingTotal
    {
        private List<int> items = new List<int>();
        private List<int[]> storedArray = new List<int[]>();

        public static void Main(string[] args)
        {
            MovingTotal movingTotal = new MovingTotal();

            movingTotal.Append(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(movingTotal.Contains(6));
            Console.WriteLine(movingTotal.Contains(9));
            Console.WriteLine(movingTotal.Contains(12));
            Console.WriteLine(movingTotal.Contains(7));

            movingTotal.Append(new int[] { 5 });

            Console.WriteLine(movingTotal.Contains(6));
            Console.WriteLine(movingTotal.Contains(9));
            Console.WriteLine(movingTotal.Contains(12));
            Console.WriteLine(movingTotal.Contains(7));
        }

        public void Append(int[] list)
        {
            this.items.AddRange(list);
        }

        public bool Contains(int total)
        {
            int[] array = this.items.ToArray();

            var size = array.Length - 1;
            var indexToMove = 0;
            int sum = 0;

            while (sum <= total)
            {
                if (sum == total) return true;
                if (indexToMove > size || (indexToMove + 1) > size || (indexToMove + 2) > size) return false;

                var n0 = array[indexToMove];
                var n1 = array[indexToMove + 1];
                var n2 = array[indexToMove + 2];

                sum = n0 + n1 + n2;

                if (sum == total) return true;

                indexToMove += 1;
            }
            return false;
        }
    }
}
