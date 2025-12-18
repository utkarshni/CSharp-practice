// See https://aka.ms/new-console-template for more information
//using system is a package
/*public class Code
{
    public static void Main()// garbage collector will never collect tha variable or line that has static
    {
        Console.WriteLine("enter your name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + "!");
    }
}*/
//Code.Main(); // class name.function name() // if i want to run in other file
/*using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        string? input = Console.ReadLine();

        // Convert input to integer safely
        int num = Convert.ToInt32(input); // null becomes 0

        if (IsPrime(num))
            Console.WriteLine($"{num} is a prime number.");
        else
            Console.WriteLine($"{num} is not a prime number.");
    }
}*/
//this code is for try parse
/*using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter age: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            bool isAdult = age >= 18;
            Console.WriteLine("Adult? " + isAdult);
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a whole number.");
        }
    }
}*/
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter radius: ");//write take u to the next line while write keeps u there only
        string? input = Console.ReadLine();

        if (!double.TryParse(input, out double radius))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (radius < 0)
        {
            Console.WriteLine("Radius cannot be negative.");
            return;
        }

        double area = 3.14 * radius * radius;
        Console.WriteLine($"Area of circle = {area:F2}");
    }
}

