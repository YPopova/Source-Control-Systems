using System;
using System.Collections.Generic;
using System.Linq;
class PythagoreanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        bool exists = false;
        if (arr.Contains(0))
        {
            exists = true;
            Console.WriteLine("0*0 + 0*0 = 0*0");
            for(int i=1;i<n;i++){
                Console.WriteLine("{0}*{0} + {1}*{1} = {1}*{1}", 0, arr[i]);
            }
        }
        for (int i = 0; i < n-2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int t = j + 1; t < n; t++)
                {
                    int a = arr[i];
                    int b = arr[j];
                    int c = arr[t];
                    if (a * a + b * b == c * c)
                    {
                        exists = true;
                        Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", a, b, c);
                    }
                }
            }
        }
        if (exists == false)
        {
            Console.WriteLine("No");
        }
    }
}

