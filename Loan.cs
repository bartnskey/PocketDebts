using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    abstract class Loan
    {
        public string loanType { get; set; }

        public double loanAmount { get; set; }

        public string instalmentType { get; set; }

        public int instalmentQuantity { get; set; }

        public double instalmentAmount { get; set; }

        public double interestRate { get; set; }

        public string loanFeeType { get; set; }

        public double loanFee { get; set; }
    }
}