using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    class Methods : Loan
    {
        private double interestAmount { get; set; }

        private double interestAmountOverpayment { get; set; }

        private double interestRateOverpayment { get; set; }

        private double overpayment { get; set; }

        private double totalLoanAmount { get; set; }

        private double totalInterestAmount { get; set; }

        private double capitalAmount { get; set; }

        private int monthsPassed { get; set; }

        private double loanFeeValue { get; set; }

        private double loanFeeValueOverpayment { get; set; }

        private double lessInstalmentAmountOverpayment { get; set; }

        private double reducePeriodOfLoanPayment { get; set; }

        public void RealInterestRate()
        {
            double realInterestRate = totalInterestAmount / loanAmount * 100;
        }

        public double InterestAmount(out double interestAmount)
        {
            interestAmount = loanAmount * (interestRate / 100) / 12;
            Console.WriteLine($"interestAmount is equal to {Math.Round(interestAmount, 2, MidpointRounding.AwayFromZero)}");
            return Math.Round(interestAmount, 2, MidpointRounding.AwayFromZero);
        }

        public void InterestAmountOverpayment()
        {
            double interestAmountOverpayment = ((loanAmount - capitalAmount - overpayment) * interestRate / 100) / 12;
        }

        public double CapitalAmount(double interestAmount, out double capitalAmount)
        {
            capitalAmount = instalmentAmount - interestAmount;
            Console.WriteLine($"capitalAmount is equal to {Math.Round(capitalAmount, 2, MidpointRounding.AwayFromZero)}");
            return Math.Round(capitalAmount, 2, MidpointRounding.AwayFromZero);
        }

        public void LoanFeeValue()
        {
            double loanFeeValue = loanAmount * loanFee;
        }

        public void LoanFeeValueOverpayment()
        {
            double loanFeeValueOverpayment = overpayment * interestRateOverpayment;
        }

        public void TotalLoanAmount()
        {
            double totalLoanAmount = instalmentAmount * instalmentQuantity;
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
