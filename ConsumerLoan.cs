using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    class ConsumerLoan : Methods
    {
        public int instalmentQuantity;

        public int consumerLoanInstalmentQuantity
        {
            get { return instalmentQuantity; }
            set
            {
                if (value > 120)
                    Console.WriteLine("There are not existing consumer loans with that length, please try again");
                else if (value < 3)
                    Console.WriteLine("There are not existing consumer loans with that length, please try again");
                else
                    instalmentQuantity = value;
            }
        }
    }
}
