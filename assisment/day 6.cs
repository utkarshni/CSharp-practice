// See https://aka.ms/new-console-template for more information

/*using System;

public class Book
{
    public string title;
    public string author;
    public int numPages;
    public DateTime dueDate;
    public DateTime returnedDate;

    public Book()
    {
    }

    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
    }

    public double AveragePagesReadPerDay(int daysToRead)
    {
        return (double)numPages / daysToRead;
    }

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int daysLate = (returnedDate - dueDate).Days;
        return daysLate * dailyLateFeeRate;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the title");
        string title = Console.ReadLine();

        Console.WriteLine("Enter the author");
        string author = Console.ReadLine();

        Console.WriteLine("Enter the number of pages");
        int pages = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the due date");
        DateTime dueDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Enter the return date");
        DateTime returnDate = DateTime.Parse(Console.ReadLine());

        Book book = new Book(title, author, pages, dueDate, returnDate);

        Console.WriteLine("Enter the days to read");
        int daysToRead = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the daily late feeRate");
        double lateFeeRate = double.Parse(Console.ReadLine());

        Console.WriteLine("Average Pages Read Per Day : " +
            Math.Floor(book.AveragePagesReadPerDay(daysToRead)));

        Console.WriteLine("Late Fee : " +
            book.CalculateLateFee(lateFeeRate));
    }
}
*/
/*
using System;

public class Cab
{
    public string BookingID { get; set; }
    public string CabType { get; set; }
    public double Distance { get; set; }
    public int WaitingTime { get; set; }
}

public class CabDetails : Cab
{
    public bool ValidateBookingID()
    {
        if (BookingID.Length == 6 &&
            BookingID.StartsWith("AC@") &&
            char.IsDigit(BookingID[3]) &&
            char.IsDigit(BookingID[4]) &&
            char.IsDigit(BookingID[5]))
        {
            return true;
        }
        return false;
    }

    public double CalculateFareAmount()
    {
        double pricePerKm = 0;

        if (CabType == "Hatchback")
            pricePerKm = 10;
        else if (CabType == "Sedan")
            pricePerKm = 20;
        else if (CabType == "SUV")
            pricePerKm = 30;

        double waitingCharge = Math.Sqrt(WaitingTime);
        double fare = (Distance * pricePerKm) + waitingCharge;

        return Math.Floor(fare * 100) / 100;
    }
}

public class Program
{
    public static void Main()
    {
        CabDetails cab = new CabDetails();

        Console.WriteLine("Enter Booking ID");
        cab.BookingID = Console.ReadLine();

        Console.WriteLine("Enter Cab Type");
        cab.CabType = Console.ReadLine();

        Console.WriteLine("Enter Distance");
        cab.Distance = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Waiting Time");
        cab.WaitingTime = int.Parse(Console.ReadLine());

        if (cab.ValidateBookingID())
        {
            Console.WriteLine("Valid Booking ID");
            Console.WriteLine("Fare Amount : " + cab.CalculateFareAmount());
        }
        else
        {
            Console.WriteLine("Invalid Booking ID");
        }
    }
}
*/