using System;
using System.Collections.Generic;
using System.Linq;
class CategorizeNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        int n = elements.Length;
        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = double.Parse(elements[i]);
        }
        List<double> round = new List<double>();
        List<double> nonZeroFraction = new List<double>();
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == Math.Floor(arr[i]) && !Double.IsInfinity(arr[i]))
            {
                round.Add(arr[i]);
            }
            else
            {
                nonZeroFraction.Add(arr[i]);
            }
        }
        double min1 = round.Min();
        double min2 = nonZeroFraction.Min();
        double max1 = round.Max();
        double max2 = nonZeroFraction.Max();
        double avg1 = round.Average();
        double avg2 = nonZeroFraction.Average();
        double sum1 = round.Sum();
        double sum2 = nonZeroFraction.Sum();
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}", string.Join(", ", nonZeroFraction), min2, max2, sum2, avg2);
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}", string.Join(", ", round), min1, max1, sum1, avg1);
    }
}

