using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_project.ConcreetHandlers
{
    /*example and general idea from: https://www.dofactory.com/net/chain-of-responsibility-design-pattern*/
    /* this class has been modified to better let the user understand what is happening*/
    class Director : AbstractApprover
    {
        private int MAX_AMOUNT = 10000;
        public override object Handle(Purchase purchase_)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("{0} ", this.GetType().Name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("exsamins request# {0}", purchase_.number);
            if (purchase_.amount < MAX_AMOUNT)
            {

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("{0} ", this.GetType().Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("approved request# {0}", purchase_.number);
                return (" ");
            }
            else
            {
                CheckEnd(purchase_);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("'The purchase of this too high for me to approve'");
                Console.WriteLine("'Better hand it over to the VicePresident'");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("*sends request# {0} to the VicePresident*", purchase_.number);

                return base.Handle(purchase_);
            }
        }
        
    }
}
