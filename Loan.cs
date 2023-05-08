using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LoanKnot
{
    abstract class Loan
    {
        public int loanAmount { get; set; }

        public int instalmentQuantity { get; set; }

        public string instalmentType { get; set; }

        public double instalmentAmount { get; set; }

        public double loanFee { get; set; }

        public double interestRate { get; set; }

        public double interestRateOverpayment { get; set; }

        public double interestAmount { get; set; }

        public int overpayment { get; set; }

        public double totalLoanAmount { get; set; }

        public double totalInterestAmount { get; set; }

        public double capitalAmount { get; set; }

        public int monthsPassed { get; set; }


        public void RealInterestRate()
        {
            double realInterestRate = totalInterestAmount / loanAmount * 100;
        }

        public void InterestAmount()
        {
            double interestAmount = loanAmount * interestRate / 12;
        }

        public void InterestAmountOverpayment()
        {
            double interestAmountOverpayment = ((loanAmount - capitalAmount - overpayment) * interestRate / 100) / 12;
        }

        public void CapitalAmount()
        {
            double capitalAmount = instalmentAmount - interestAmount;
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
            var lessInstalmentAmountOverpayment = (loanAmount * interestRate / 100 / 12 * (1 + interestRate / 100 / 12) ^ monthsPassed) / ((1 + interestRate / 100 / 12) ^ monthsPassed - 1);
        }
    }
}