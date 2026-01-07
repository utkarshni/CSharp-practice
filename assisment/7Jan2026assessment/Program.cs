using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        Console.WriteLine("=== PETTY CASH SYSTEM ===");
        Console.WriteLine();
        Console.Write("Enter Income ID: ");
        int incomeId = int.Parse(Console.ReadLine());

        Console.Write("Enter Income Amount: ");
        decimal incomeAmount = decimal.Parse(Console.ReadLine());

        Console.Write("Enter Income Description: ");
        string incomeDescription = Console.ReadLine();

        Console.Write("Enter Income Source: ");
        string incomeSource = Console.ReadLine();

        incomeLedger.AddEntry(
            new IncomeTransaction(
                incomeId,
                DateTime.Today,
                incomeAmount,
                incomeDescription,
                incomeSource
            )
        );

        Console.WriteLine("\nIncome recorded successfully.\n");
        for (int i = 1; i <= 2; i++)
        {
            Console.WriteLine($"Enter Expense {i} Details");

            Console.Write("Expense ID: ");
            int expenseId = int.Parse(Console.ReadLine());

            Console.Write("Expense Amount: ");
            decimal expenseAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Expense Description: ");
            string expenseDescription = Console.ReadLine();

            Console.Write("Expense Category: ");
            string expenseCategory = Console.ReadLine();

            expenseLedger.AddEntry(
                new ExpenseTransaction(
                    expenseId,
                    DateTime.Today,
                    expenseAmount,
                    expenseDescription,
                    expenseCategory
                )
            );

            Console.WriteLine("Expense recorded.\n");
        }
        decimal totalIncome = incomeLedger.CalculateTotal();
        decimal totalExpense = expenseLedger.CalculateTotal();
        decimal netBalance = totalIncome - totalExpense;

        Console.WriteLine("=== SUMMARY ===");
        Console.WriteLine("Total Income: $" + totalIncome);
        Console.WriteLine("Total Expenses: $" + totalExpense);
        Console.WriteLine("Net Balance: $" + netBalance);
        Console.WriteLine();
        List<Transaction> allTransactions = new List<Transaction>();
        allTransactions.AddRange(incomeLedger.GetAll());
        allTransactions.AddRange(expenseLedger.GetAll());

        Console.WriteLine("Transaction Details:");
        foreach (Transaction transaction in allTransactions)
        {
            Console.WriteLine(transaction.GetSummary());
        }
    }
}
