using System;
class SelectionSort
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');
        int[] arr = new int[elements.Length];
        for (int i = 0; i < elements.Length; i++)
        {
            arr[i] = int.Parse(elements[i]);
        }
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[min];
            arr[min] = arr[i];
            arr[i] = temp;
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}

