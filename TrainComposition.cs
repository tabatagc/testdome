namespace TestDome
{
    using System;
    using System.Collections.Generic;

    public class TrainComposition
    {
        private LinkedList<int> trains = new LinkedList<int>();

        public static void Main(string[] args)
        {
            TrainComposition train = new TrainComposition();
            train.AttachWagonFromLeft(7);
            train.AttachWagonFromLeft(13);
            Console.WriteLine(train.DetachWagonFromRight()); // 7
            Console.WriteLine(train.DetachWagonFromLeft()); // 13
        }

        public void AttachWagonFromLeft(int wagonId)
        {
            trains.AddFirst(wagonId);
        }

        public void AttachWagonFromRight(int wagonId)
        {
            trains.AddLast(wagonId);
        }

        public int DetachWagonFromLeft()
        {
            int x = trains.First.Value;
            trains.RemoveFirst();

            return x;
        }

        public int DetachWagonFromRight()
        {
            int y = trains.Last.Value;
            trains.RemoveLast();

            return y;
        }
    }
}
