using System;

namespace LoanKnot
{
    class Program : Loan
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter load Amount");
            int loanAmount = int.TryParse(Console.ReadLine());
        }
    }
}