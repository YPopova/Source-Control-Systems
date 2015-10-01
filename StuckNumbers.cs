using System;
using System.Collections.Generic;
using System.Linq;
class StuckNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> arr = Console.ReadLine().Trim().Split().ToList();
        List<string> arr2 = arr;
        int counter = 0;
        foreach (string x in arr)
        {
            arr2 = arr.ToList();
            arr2.Remove(x);
            foreach (string y in arr2.ToList())
            {
                arr2.Remove(y);
                foreach (string z in arr2.ToList())
                {
                    arr2.Remove(z);
                    foreach (string w in arr2)
                    {
                        if (x + y == z + w)
                        {
                            counter++;
                            Console.WriteLine("{0}|{1}=={2}|{3}", x, y, z, w);
                        }
                    }
                    arr2.Add(z);
                }
                arr2.Add(y);
            }
            arr2.Add(x);
        }
        if (counter == 0)
        {
            Console.WriteLine("No");
        }
    }
}

