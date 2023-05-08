using System;

namespace PocketDebts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing


            HomeLoan HomeLoan = new HomeLoan();

            Console.WriteLine("Enter loan amount");
            HomeLoan.loanAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment quantity");
            HomeLoan.instalmentQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment amount");
            HomeLoan.instalmentAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter insterest rate");
            HomeLoan.interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter loan fee");
            HomeLoan.loanFee = double.Parse(Console.ReadLine());

            HomeLoan.InterestAmount();
            HomeLoan.CapitalAmount();
        }
    }
}