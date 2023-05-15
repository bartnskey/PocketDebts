using System;


namespace PocketDebts
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary> 

            /// Console application for training acquired basics in C#.
            /// App allows to entry data of your debts and calculate:
            /// - How much interests you need to pay
            /// - Total cost of your debt
            /// - Divides payment for interest with capital
            /// - And more

            /// </summary> 

            /// <param name="args">Invoke to call the application</param> 


            Methods methods = new Methods();
            methods.LoanParametersFromUser();

            if (methods.loanType == "1")
            {
                Loan home = new Loan();

                methods.TotalLoanAmount(out double totalLoanAmount);
                methods.TotalInterestAmount(out double totalInterestAmount);
                methods.RealInterestRate(out double realInterestRate);
                methods.InterestAmount(out double interestAmount);
                methods.CapitalAmount(interestAmount, out double capitalAmount);

            }
            else if (methods.loanType == "2")
            {
                Loan consumer = new Loan();

                methods.InterestAmount(out double interestAmount);
                methods.CapitalAmount(interestAmount, out double capitalAmount);
            }
            else if (methods.loanType == "3")
            {
                Loan other = new Loan();

                methods.InterestAmount(out double interestAmount);
                methods.CapitalAmount(interestAmount, out double capitalAmount);
            }
            else
            {
                Console.WriteLine("Wrong choice, try again");
            }


        }
    }
}