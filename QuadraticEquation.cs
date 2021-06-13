namespace TestDome
{
    using System;

    public class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            double sqrt = Math.Sqrt(b * b - 4 * a * c);
            double x = (-b + sqrt) / (2.0 * a);
            double y = (-b - sqrt) / (2.0 * a);

            return Tuple.Create(x, y);
        }

        public static void Main(string[] args)
        {
            Tuple<double, double> roots = QuadraticEquation.FindRoots(2, 10, 8);
            Console.WriteLine("Roots: " + roots.Item1 + ", " + roots.Item2); //-1, -4
        }
    }
}
