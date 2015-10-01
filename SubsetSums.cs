using System;
using System.Collections.Generic;
using System.Linq;
class SubsetSums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        int[] arr = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            arr[i] = int.Parse(elements[i]);
        }
        int[] res = arr.Distinct().ToArray(); 
        int numberOfSubsets = 1<<res.Length;
        bool exists = false;
        List<int> current = new List<int>();
        List<List<int>> answers = new List<List<int>>();
        for (int i = 1; i < numberOfSubsets; i++) 
        {
            int currentSum = 0;
            for (int j = 0; j < res.Length; j++)
            {
                int mask = i & (1 << j);
                if (mask != 0)
                {
                    currentSum += res[res.Length - 1 - j];
                    current.Add(res[res.Length - 1 - j]);
                }
            }
            if (currentSum == sum)
            {
                exists = true;
                answers.Add(current);
            }
            current = new List<int>();
        }
        if (exists == false)
        {
            Console.WriteLine("No matching subsets.");
        }
        else
        {
            for (int i = 0; i < answers.Count(); i++)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", answers[i]), sum);
            }
        }
    }
}
