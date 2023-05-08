using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    class Methods : Loan
    {
        private double interestAmount;

        public double interestRateOverpayment { get; set; }

        public double overpayment { get; set; }

        public double totalLoanAmount { get; set; }

        public double totalInterestAmount { get; set; }

        private double capitalAmount;

        public int monthsPassed { get; set; }

        public virtual int CheckInstalmentQuantity()
        {
            return this.instalmentQuantity;
        }

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
            double loadnFeeValueOverpayment = overpayment * interestRateOverpayment;
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
