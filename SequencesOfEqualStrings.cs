using System;
using System.Collections.Generic;
using System.Linq;
class SequencesOfEqualStrings
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        Queue<string> q = new Queue<string>();
        for (int i = 0; i < elements.Length; i++)
        {
            q.Enqueue(elements[i]);
        }
        string a = q.Peek();
        Console.Write(q.Dequeue());
        while (q.Count > 0)
        {
            if (q.Peek() == a)
            {
                Console.Write(" " + q.Dequeue());
            }
            else
            {
                Console.WriteLine();
                a = q.Peek();
                Console.Write(q.Dequeue());
            }
        }
    }
}

