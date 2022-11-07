using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_project
{
    /*example and general idea from: https://www.dofactory.com/net/chain-of-responsibility-design-pattern*/
    /*class modified due to unnesassery compexity*/
    public class Purchase
    {
        public int    number  { get; set; }
        public double amount  { get; set; }
        public string purpose { get; set; }

        public Purchase(int number, double amount, string purpose)
        {
            this.number  = number;
            this.amount  = amount;
            this.purpose = purpose;
        }
    }
}
