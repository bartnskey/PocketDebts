using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocketDebts
{
    class HomeLoan : Methods
    {
        public int instalmentQuantity;

        public int homeLoanInstalmentQuantity
        {
            get { return instalmentQuantity; }
            set
            {
                if (value > 420)
                    Console.WriteLine("There are not existing home loans with that length, please try again");
                else if (value < 12)
                    Console.WriteLine("There are not existing home loans with that length, please try again");
                else
                    instalmentQuantity = value;
            }
        }
    }
}
