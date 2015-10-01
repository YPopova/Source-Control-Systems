using System;
using System.Collections.Generic;
using System.Linq;
class LongestIncreasingSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split();
        int[] arr=new int[elements.Length];
        for(int i=0; i < elements.Length; i++)
        {
            arr[i]=int.Parse(elements[i]);
        }
        List<List<int>> many = new List<List<int>>();
        List<int> one = new List<int>();
        one.Add(arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i-1] < arr[i])
            {
                one.Add(arr[i]);
            }
            else
            {
                many.Add(one);
                one = new List<int>();
                one.Add(arr[i]);
            }
        }
        many.Add(one);
        List<int> longestSequence = new List<int>();
        for (int i = 0; i < many.Count; i++)
        {
            Console.WriteLine(string.Join(" ", many[i]));
            if (many[i].Count > longestSequence.Count)
            {
                longestSequence = many[i];
            }
        }
        Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
        
        
    }
}

