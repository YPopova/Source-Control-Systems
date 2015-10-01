using System;
using System.Collections.Generic;
using System.Linq;
class LegoBlocks
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        List<List<int>> lego1 = new List<List<int>>();
        List<List<int>> lego2 = new List<List<int>>();
        for (int i = 0; i < rows; i++)
        {
            string input = Console.ReadLine();
            List<int> sequence = new List<int>();
            sequence = input.Split(' ').Select(int.Parse).ToList();
            lego1.Add(sequence);
        }
        for (int i = 0; i < rows; i++)
        {
            string input = Console.ReadLine();
            List<int> sequence = new List<int>();
            sequence = input.Split(' ').Select(int.Parse).ToList();
            lego2.Add(sequence);
        }
        bool fits = true;
        int counter = 0;
        for (int i = 0; i < rows; i++)
        {
            lego2[i].Reverse();
            lego1[i].AddRange(lego2[i]);
        }
        int num = lego1[0].Count();
        for (int i = 0; i < rows; i++)
        {
            if (lego1[i].Count() != num)
            {
                fits = false;
                break;
            }
        }
        if (fits == true)
        {
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", lego1[i]));
            }
             
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                counter += lego1[i].Count();
            }
            Console.WriteLine("The total number of cells is: {0}", counter);
        }
    }
}

