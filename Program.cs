using System;

public class Program
{
    public static Tuple<int, int> FindMinMax(int[] arr)
    {
        int max = arr[0], min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            if (arr[i] < min) min = arr[i];
        }
        return Tuple.Create(min, max);
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 5, 3, 8, 2 };
        Tuple<int, int> minMax = FindMinMax(arr);
        Console.WriteLine("Min: " + minMax.Item1);
        Console.WriteLine("Max: " + minMax.Item2);
    }
}
