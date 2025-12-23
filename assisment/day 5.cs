// See https://aka.ms/new-console-template for more information

/*using System;
public class Computer
{
    public string Processor { get; set; }
    public int RamSize { get; set; }
    public int HardDiskSize { get; set; }
    public int GraphicCard { get; set; }
}
public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }

    public double DesktopPriceCalculation()
    {
        double processorCost = 0;

        switch (Processor)
        {
            case "i3":
                processorCost = 1500;
                break;
            case "i5":
                processorCost = 3000;
                break;
            case "i7":
                processorCost = 4500;
                break;
        }

        double price = processorCost
                     + (RamSize * 200)
                     + (HardDiskSize * 1500)
                     + (GraphicCard * 2500)
                     + (MonitorSize * 250)
                     + (PowerSupplyVolt * 20);

        return price;
    }
}
public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }

    public double LaptopPriceCalculation()
    {
        double processorCost = 0;

        switch (Processor)
        {
            case "i3":
                processorCost = 2500;
                break;
            case "i5":
                processorCost = 5000;
                break;
            case "i7":
                processorCost = 6500;
                break;
        }

        double price = processorCost
                     + (RamSize * 200)
                     + (HardDiskSize * 1500)
                     + (GraphicCard * 2500)
                     + (DisplaySize * 250)
                     + (BatteryVolt * 20);

        return price;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.WriteLine("Choose the option");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Desktop d = new Desktop();

            Console.WriteLine("Enter the processor(i3,i5,i7)");
            d.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            d.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            d.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            d.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the monitor size");
            d.MonitorSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the power supply volt");
            d.PowerSupplyVolt = int.Parse(Console.ReadLine());

            double price = d.DesktopPriceCalculation();
            Console.WriteLine("Desktop price is " + price);
        }
        else if (choice == 2)
        {
            Laptop l = new Laptop();

            Console.WriteLine("Enter the processor(i3,i5,i7)");
            l.Processor = Console.ReadLine();

            Console.WriteLine("Enter the ram size");
            l.RamSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hard disk size");
            l.HardDiskSize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the graphic card size");
            l.GraphicCard = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the display size");
            l.DisplaySize = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the battery volt");
            l.BatteryVolt = int.Parse(Console.ReadLine());

            double price = l.LaptopPriceCalculation();
            Console.WriteLine("Laptop price is " + price);
        }
    }
}*/
/*
using System;
public class InvalidFlavourException : Exception
{
    public InvalidFlavourException(string message) : base(message)
    {
    }
}

public class Cake
{
    public string Flavour { get; set; }
    public int QuantityInKg { get; set; }
    public double PricePerKg { get; set; }
    public bool CakeOrder()
    {
        if (Flavour != "Chocolate" && Flavour != "Red Velvet" && Flavour != "Vanilla")
        {
            throw new InvalidFlavourException(
                "Flavour not available. Please select the available flavour");
        }

        if (QuantityInKg <= 0)
        {
            throw new Exception("Quantity must be greater than zero");
        }

        return true;
    }
    public double CalculatePrice()
    {
        double discount = 0;

        if (Flavour == "Vanilla")
            discount = 3;
        else if (Flavour == "Chocolate")
            discount = 5;
        else if (Flavour == "Red Velvet")
            discount = 10;

        double totalPrice = QuantityInKg * PricePerKg;
        double discountedPrice = totalPrice - (totalPrice * discount / 100);

        return discountedPrice;
    }
}

class Program
{
    static void Main()
    {
        Cake cake = new Cake();

        try
        {
            Console.WriteLine("Enter the flavour");
            cake.Flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity in kg");
            cake.QuantityInKg = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price per kg");
            cake.PricePerKg = double.Parse(Console.ReadLine());

            if (cake.CakeOrder())
            {
                Console.WriteLine("Cake order was successful");
                Console.WriteLine("Price after discount is " + cake.CalculatePrice());
            }
        }
        catch (InvalidFlavourException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
*/
/*
using System;

public class Candy
{
    public string Flavour { get; set; }
    public int Quantity { get; set; }
    public int PricePerPiece { get; set; }
    public double TotalPrice { get; set; }
    public double Discount { get; set; }

    public bool ValidateCandyFlavour()
    {
        if (Flavour == "Strawberry" || Flavour == "Lemon" || Flavour == "Mint")
            return true;
        else
            return false;
    }
}

class Program
{
    public static Candy CalculateDiscountedPrice(Candy candy)
    {
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

        if (candy.Flavour == "Strawberry")
            candy.Discount = 15;
        else if (candy.Flavour == "Lemon")
            candy.Discount = 10;
        else if (candy.Flavour == "Mint")
            candy.Discount = 5;

        candy.Discount = candy.TotalPrice -
                          (candy.TotalPrice * candy.Discount / 100);

        return candy;
    }

    static void Main()
    {
        Candy candy = new Candy();

        Console.WriteLine("Enter the flavour");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity");
        candy.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the price per piece");
        candy.PricePerPiece = int.Parse(Console.ReadLine());

        if (candy.ValidateCandyFlavour())
        {
            candy = CalculateDiscountedPrice(candy);

            Console.WriteLine("Flavour : " + candy.Flavour);
            Console.WriteLine("Quantity : " + candy.Quantity);
            Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
            Console.WriteLine("Total Price : " + candy.TotalPrice);
            Console.WriteLine("Discount Price : " + candy.Discount);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }
}
*/