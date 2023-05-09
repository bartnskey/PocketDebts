using System;


namespace PocketDebts
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan loan = new Loan();

            Console.WriteLine("Enter loan type: 1 - Home loan, 2 - Consumer loan, 3 - Other payments");
            loan.loanType = Console.ReadLine();

            if (loan.loanType == "1")
            {
                HomeLoan homeLoan = new HomeLoan();

                homeLoan.InterestAmount(out double interestAmount);
                homeLoan.CapitalAmount(interestAmount, out double capitalAmount);
            }
            else if (loan.loanType == "2")
            {
                ConsumerLoan consumerLoan = new ConsumerLoan();
            }
            else if (loan.loanType == "3")
            {
                OtherPayments otherPayments = new OtherPayments();
            }
            else
            {
                Console.WriteLine("Wrong choice, try again");
            }


            Console.WriteLine("Enter loan amount");
            loan.loanAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment type: 1 - variable, 2 - fixed");
            loan.instalmentType = Console.ReadLine();

            Console.WriteLine("Enter instalment quantity");
            loan.instalmentQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment amount");
            loan.instalmentAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter insterest rate");
            loan.interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter loan fee type: 1 - percent, 2 - amount");
            loan.loanFeeType = Console.ReadLine();

            Console.WriteLine("Enter loan fee");
            loan.loanFee = double.Parse(Console.ReadLine());


        }
    }
}