using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    class Methods : Loan
    {
        private double interestRateOverpayment { get; set; }

        private double overpayment { get; set; }

        private double totalLoanAmount { get; set; }

        private double totalInterestAmount { get; set; }

        private double capitalAmount { get; set; }

        private int monthsPassed { get; set; }

        public void LoanParametersFromUser()
        {
            Console.WriteLine("Enter loan type: 1 - Home loan, 2 - Consumer loan, 3 - Other payments");
            loanType = Console.ReadLine();

            Console.WriteLine("Enter loan amount");
            loanAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment quantity");
            instalmentQuantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment amount");
            instalmentAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter insterest rate");
            interestRate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter loan fee type: 1 - percent, 2 - amount");
            loanFeeType = Console.ReadLine();

            Console.WriteLine("Enter loan fee");
            loanFee = double.Parse(Console.ReadLine());
        }

        public double TotalLoanAmount(out double totalLoanAmount)
        {
            totalLoanAmount = instalmentAmount * instalmentQuantity;
            Console.WriteLine($"totalLoanAmount is equal to {totalLoanAmount} PLN");
            return totalLoanAmount;
        }

        public void TotalInterestAmount(out double totalInterestAmount)
        {
            totalInterestAmount = totalLoanAmount - loanAmount;
            Console.WriteLine($"totalInterestAmount is equal to {totalInterestAmount} PLN");
        }

        public void RealInterestRate(out double realInterestRate)
        {
            realInterestRate = totalInterestAmount / loanAmount * 100;
            Console.WriteLine($"realInterestRate is equal to {realInterestRate} %");
        }

        public double InterestAmount(out double interestAmount)
        {
            interestAmount = loanAmount * (interestRate / 100) / 12;
            Console.WriteLine($"interestAmount is equal to {Math.Round(interestAmount, 2, MidpointRounding.AwayFromZero)} PLN");
            return Math.Round(interestAmount, 2, MidpointRounding.AwayFromZero);
        }

        public double CapitalAmount(double interestAmount, out double capitalAmount)
        {
            capitalAmount = instalmentAmount - interestAmount;
            Console.WriteLine($"capitalAmount is equal to {Math.Round(capitalAmount, 2, MidpointRounding.AwayFromZero)} PLN");
            return Math.Round(capitalAmount, 2, MidpointRounding.AwayFromZero);
        }

        public void InterestAmountOverpayment()
        {
            double interestAmountOverpayment = ((loanAmount - capitalAmount - overpayment) * interestRate / 100) / 12;
        }

        
        public void LoanFeeValue()
        {
            double loanFeeValue = loanAmount * loanFee;
        }

        public void LoanFeeValueOverpayment()
        {
            double loanFeeValueOverpayment = overpayment * interestRateOverpayment;
        }

        

        public void TotalInterestAmount()
        {
            double totalInterestAmount = totalLoanAmount - loanAmount;
        }

        public void LessInstalmentAmountOverpayment()
        {
            double lessInstalmentAmountOverpayment = (loanAmount * (interestRate / 100 / 12) * Math.Pow(1 + interestRate / 100 / 12, monthsPassed) / (Math.Pow(1 + interestRate / 100 / 12, monthsPassed) - 1));
        }

        public void ReducePeriodOfLoanPayment()
        {
            double reducePeriodOfLoanPayment = -Math.Log(1 - ((interestRate / 12) * loanAmount) / instalmentAmount) / Math.Log(1 + interestRate / 12);
        }
    }
}
