namespace TestDome
{
    using System;

    public static partial class Extensions
    {
        public static Double Log10(this Double d)
        {
            return Math.Log10(d);
        }
    }

    public class LogParseExtension
    {
        public static void Main()
        {
            //double[] numbers = { -1, 0, .105, .5, .798, 1, 4, 6.9, 10, 50, 100, 500, 1000, Double.MaxValue };
            double[] numbers = { 10 };

            foreach (double number in numbers)
            {
                Console.WriteLine("The base 10 log of {0} is {1}.", number, number.Log10());//1
            }
        }
    }
}
