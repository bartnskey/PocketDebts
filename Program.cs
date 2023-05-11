using System;


namespace PocketDebts
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            methods.LoanParametersFromUser();

            if (methods.loanType == "1")
            {
                HomeLoan homeLoan = new HomeLoan(methods.instalmentQuantity);

                homeLoan.InterestAmount(out double interestAmount);
                homeLoan.CapitalAmount(interestAmount, out double capitalAmount);
            }
            else if (methods.loanType == "2")
            {
                ConsumerLoan consumerLoan = new ConsumerLoan();
            }
            else if (methods.loanType == "3")
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