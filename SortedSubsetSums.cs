using System;
using System.Collections.Generic;
using System.Linq;
class SortedSubsetSums
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
        int numberOfSubsets = 1 << res.Length;
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
            List<List<int>> newAnswers = new List<List<int>>(answers.OrderBy(x => x.Count()));
            foreach (var answer in newAnswers) 
            {
                answer.Sort();
            }
            for (int i = 0; i < newAnswers.Count - 1; i++)
            {
                int first = newAnswers[i].First();
                for (int j = i + 1; j < newAnswers.Count; j++)
                {
                    int second = newAnswers[j].First();
                    if (newAnswers[i].Count == newAnswers[j].Count && first > second)
                    {
                        List<int> temp = newAnswers[i];
                        newAnswers[i] =newAnswers[j];
                        newAnswers[j] = temp;
                    }
                }
            }
            for (int i = 0; i < newAnswers.Count(); i++)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", newAnswers[i]), sum);
            }
        }
    }
}

