namespace TestDome
{
    using System;
    using System.Collections.Generic;

    public class WeightedAverage
    {
        public static void Main(string[] args)
        {
            var inputWeights = new[] { 4, 2 };
            var inputValues = new[] { 3, 6 };

            Console.WriteLine();
            Console.WriteLine(WeightedAverage.Mean(inputValues, inputWeights)); //only result 4
        }

        public static double Mean(IList<int> numbers, IList<int> weights)
        {
            long result = 0;
            long totalWeights = 0;

            if (numbers is null || weights is null || numbers.Count != weights.Count)
                throw new ArgumentException("Error: Please insert again, values null or Length mismatch!");

            for (var i = 0; i < numbers.Count; i++)
            {
                result += numbers[i] * weights[i];

                totalWeights += weights[i];
            }

            return (result / (double)totalWeights);
        }
    }
}
