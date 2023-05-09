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

        public void LoanParametersFromUser()
        {
            Console.WriteLine("Enter loan type: 1 - Home loan, 2 - Consumer loan, 3 - Other payments");
            loanType = Console.ReadLine();

            Console.WriteLine("Enter loan amount");
            loanAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter instalment type: 1 - variable, 2 - fixed");
            instalmentType = Console.ReadLine();

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
    }
}