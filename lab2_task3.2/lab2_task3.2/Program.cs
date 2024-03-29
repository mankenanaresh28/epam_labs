using System;

public enum SortOrder
{
    Ascending,
    Descending
}

class Program
{
    static bool IsSorted(int[] arr, SortOrder order)
    {
        if (order == SortOrder.Ascending)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
        }
        else if (order == SortOrder.Descending)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] < arr[i + 1])
                    return false;
            }
        }

        return true;
    }

    static void Transform(int[] arr, SortOrder order)
    {
        if (IsSorted(arr, order))
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += i;
            }
        }
    }

    static void Main(string[] args)
    {
        int[] array1 = { 5, 17, 24, 88, 33, 2 };
        SortOrder order1 = SortOrder.Ascending;
        Transform(array1, order1);
        Console.WriteLine("Transformed Array 1:");
        foreach (var item in array1)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int[] array2 = { 15, 10, 3 };
        SortOrder order2 = SortOrder.Ascending;
        Transform(array2, order2);
        Console.WriteLine("Transformed Array 2:");
        foreach (var item in array2)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        int[] array3 = { 15, 10, 3 };
        SortOrder order3 = SortOrder.Descending;
        Transform(array3, order3);
        Console.WriteLine("Transformed Array 3:");
        foreach (var item in array3)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
