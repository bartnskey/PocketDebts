using System;

namespace PocketDebts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing

            HomeLoan HomeLoan = new HomeLoan();

            Console.WriteLine("Enter loan type: 1 - Home loan, 2 - Consumer loan, 3 - payments");
            HomeLoan.loanType = Console.ReadLine();

            Console.WriteLine("Enter loan amount");
            HomeLoan.loanAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment type: 1 - variable, 2 - fixed");
            HomeLoan.instalmentType = Console.ReadLine();

            Console.WriteLine("Enter instalment quantity");
            HomeLoan.instalmentQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment amount");
            HomeLoan.instalmentAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter insterest rate");
            HomeLoan.interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter loan fee type: 1 - percent, 2 - amount");
            HomeLoan.loanFeeType = Console.ReadLine();

            Console.WriteLine("Enter loan fee");
            HomeLoan.loanFee = double.Parse(Console.ReadLine());

            HomeLoan.InterestAmount(out double interestAmount);
            HomeLoan.CapitalAmount(interestAmount, out double capitalAmount);
        }
    }
}