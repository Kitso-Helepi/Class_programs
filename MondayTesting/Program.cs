using System;

internal class Program
{
    static double constantly(string prompt)
    {
        while (true)
        {   
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be empty. Please enter a valid number.");
                continue;
            }

            if (double.TryParse(input.Trim(), out double result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

    }

    private static void Main(string[] args)
    {
        double loanAmount = constantly("Enter the loan amount: ");
        double annualInterestRate = constantly("Enter the annual interest rate (in decimal): ");
        double loanYears = constantly("Enter the loan term in years: ");

        double numofPayment = loanYears * 12;
        double term = Math.Pow(1 + annualInterestRate / 12, numofPayment);
        double monthlyPayment = (loanAmount * term * annualInterestRate / 12) / (term - 1);
        double monthlyInterest = loanAmount * annualInterestRate / 12;
        double monthlyPrincipal = monthlyPayment - monthlyInterest;
        double currentBalance = loanAmount - monthlyPrincipal;
        double totalPayment = monthlyPayment * numofPayment;
        double totalInterest = totalPayment - loanAmount;

        Console.WriteLine("\n{0,-10} {1,-15} {2,-15} {3, -15}, ", "Month ", "Principal", "Payment", "Balance");



    }
}