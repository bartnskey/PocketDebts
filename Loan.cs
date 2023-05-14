using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    class Loan
    {
        public string loanType { get; set; }

        public double loanAmount { get; set; }

        public string instalmentType { get; set; }

        public int instalmentQuantity { get; set; }

        public double instalmentAmount { get; set; }

        public double interestRate { get; set; }

        public string loanFeeType { get; set; }

        public double loanFee { get; set; }

        public Loan(string loanType)
        {
            if (loanType == "1")
            {
                this.loanType = "Home loan";

                if (instalmentQuantity > 420)
                {
                    
                }
                else if (instalmentQuantity < 60)
                {
                    Console.WriteLine("There are not existing home loans with that length, please try again");
                }
                else
                {
                    this.instalmentQuantity = instalmentQuantity;
                }

                if (loanAmount > 5000000)
                {
                    Console.WriteLine("There are not existing home loans with that value, please try again");
                }
                else if (loanAmount < 10000)
                {
                    Console.WriteLine("There are not existing home loans with that value, please try again");
                }
                else
                {
                    this.loanAmount = loanAmount;
                }
            }

            if (loanType == "2")
            {
                this.loanType = "Consumer loan";

                if (instalmentQuantity > 120)
                {
                    Console.WriteLine("There are not existing consumer loans with that length, please try again");
                }
                else if (instalmentQuantity < 3)
                {
                    Console.WriteLine("There are not existing consumer loans with that length, please try again");
                }
                else
                {
                    this.instalmentQuantity = instalmentQuantity;
                }

                if (loanAmount > 200000)
                {
                    Console.WriteLine("There are not existing consumer loans with that value, please try again");
                }
                else if (loanAmount < 500)
                {
                    Console.WriteLine("There are not existing consumer loans with that value, please try again");
                }
                else
                {
                    this.loanAmount = loanAmount;
                }

            if (loanType == "3")
                {
                    this.loanType = "Other payments (rent, leasing, car etc.)";
                }
            }
        }
    }
}