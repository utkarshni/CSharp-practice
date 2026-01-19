using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number (n): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter upto value: ");
        int upto = int.Parse(Console.ReadLine());

        int[] result = GetMultiplicationRow(n, upto);

        Console.WriteLine("Multiplication row:");
        Console.WriteLine(string.Join(", ", result));
    }

    static int[] GetMultiplicationRow(int n, int upto)
    {
        if (upto <= 0)
            return new int[0];

        int[] row = new int[upto];

        for (int i = 1; i <= upto; i++)
        {
            row[i - 1] = n * i;
        }

        return row;
    }
}

