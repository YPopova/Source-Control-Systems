using System;
class SortArrayOfNumbers
{
    static void Main()
    {
        string sentence = Console.ReadLine();
        string[] strArr = sentence.Split(' ');
        int[] arr = new int[strArr.Length];
        for (int i = 0; i < strArr.Length; i++)
        {
            arr[i] = int.Parse(strArr[i]);
        }
        Array.Sort(arr);
        Console.WriteLine(string.Join(" ", arr));
        //bubble sort
        /*string sentence = Console.ReadLine();
        string[] strArr = sentence.Split(' ');
        int[] arr = new int[strArr.Length];
        for (int i = 0; i < strArr.Length; i++)
        {
            arr[i] = int.Parse(strArr[i]);
        }
        bool swapped = true;
        int lastUnsorted = arr.Length-1;
        do
        {
            swapped = false;
            for (int i = 0; i < lastUnsorted; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    swapped = true;
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
            lastUnsorted--;
        } while (swapped == true);
        Console.WriteLine(string.Join(" ", arr);*/
    }
}

