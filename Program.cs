using System;


namespace PocketDebts
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan loan = new Loan();
            loan.LoanParametersFromUser();

            if (loan.loanType == "1")
            {
                HomeLoan homeLoan = new HomeLoan(loan.instalmentQuantity);

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
        }
    }
}