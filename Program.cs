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
                Loan home = new Loan();
            }
            else if (methods.loanType == "2")
            {
                Loan consumer = new Loan();
            }
            else if (methods.loanType == "3")
            {
                Loan other = new Loan();
            }
            else
            {
                Console.WriteLine("Wrong choice, try again");
            }
        }
    }
}