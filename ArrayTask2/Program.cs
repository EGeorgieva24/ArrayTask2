using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of values: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the values:");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Value {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Values in reverse order:");

        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine($"Value {i + 1}: {arr[i]}");
        }
    }
}

