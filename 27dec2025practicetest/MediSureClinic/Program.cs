﻿using System;

namespace MediSureClinic
{
    class Program
    {
        static PatientBill LastBill;
        static bool HasLastBill = false;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- MediSure Clinic System ---");
                Console.WriteLine("1. Create New Bill (Enter Patient Details)");
                Console.WriteLine("2. View Last Bill");
                Console.WriteLine("3. Clear Last Bill");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateBill();
                        break;
                    case "2":
                        ViewLastBill();
                        break;
                    case "3":
                        ClearLastBill();
                        break;
                    case "4":
                        Console.WriteLine("Thank you. Application closed normally");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose between 1 and 4.");
                        break;
                }
            }
        }
        public static void CreateBill()
        {
            PatientBill bill = new PatientBill();

            Console.Write("Enter Bill ID: ");
            bill.BillId = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(bill.BillId))
            {
                Console.WriteLine("Bill ID cannot be empty.");
                return;
            }

            Console.Write("Enter Patient Name: ");
            bill.PatientName = Console.ReadLine();

            Console.Write("Has Insurance? (Y/N): ");
            string insuranceInput = Console.ReadLine();
            bill.HasInsurance = insuranceInput.Equals("Y", StringComparison.OrdinalIgnoreCase);

            Console.Write("Enter Consultation Fee: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal consultationFee) || consultationFee <= 0)
            {
                Console.WriteLine("Consultation fee must be greater than 0.");
                return;
            }
            bill.ConsultationFee = consultationFee;

            Console.Write("Enter Lab Charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal labCharges) || labCharges < 0)
            {
                Console.WriteLine("Lab charges must be 0 or more.");
                return;
            }
            bill.LabCharges = labCharges;

            Console.Write("Enter Medicine Charges: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal medicineCharges) || medicineCharges < 0)
            {
                Console.WriteLine("Medicine charges must be 0 or more.");
                return;
            }
            bill.MedicineCharges = medicineCharges;

            bill.CalculateBill();

            LastBill = bill;
            HasLastBill = true;

            Console.WriteLine("Bill created successfully.");
        }
        public static void ViewLastBill()
        {
            if (!HasLastBill)
            {
                Console.WriteLine("No bill available. Please create a new bill first.");
                return;
            }

            Console.WriteLine("\n--- Last Patient Bill ---");
            Console.WriteLine($"Bill ID           : {LastBill.BillId}");
            Console.WriteLine($"Patient Name      : {LastBill.PatientName}");
            Console.WriteLine($"Has Insurance     : {LastBill.HasInsurance}");
            Console.WriteLine($"Consultation Fee  : {LastBill.ConsultationFee:F2}");
            Console.WriteLine($"Lab Charges       : {LastBill.LabCharges:F2}");
            Console.WriteLine($"Medicine Charges  : {LastBill.MedicineCharges:F2}");
            Console.WriteLine($"Gross Amount      : {LastBill.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount   : {LastBill.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable     : {LastBill.FinalPayable:F2}");
        }
        public static void ClearLastBill()
        {
            LastBill = null;
            HasLastBill = false;
            Console.WriteLine("Last bill cleared.");
        }
    }
}
