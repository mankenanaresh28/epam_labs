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

    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        SortOrder order1 = SortOrder.Ascending;
        Console.WriteLine("Array 1 is sorted in ascending order: " + IsSorted(array1, order1));

        int[] array2 = { 5, 4, 3, 2, 1 };
        SortOrder order2 = SortOrder.Descending;
        Console.WriteLine("Array 2 is sorted in descending order: " + IsSorted(array2, order2));

        int[] array3 = { 1, 3, 2, 4, 5 };
        SortOrder order3 = SortOrder.Ascending;
        Console.WriteLine("Array 3 is sorted in ascending order: " + IsSorted(array3, order3));
    }
}
