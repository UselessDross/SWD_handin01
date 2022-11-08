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
        public override object Handle(Purchase purchase_)
        {
            if (purchase_.amount < 10000.0)
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
                Console.WriteLine("");
                Console.WriteLine("*sends request# {0} to the VicePresident*", purchase_.number);
                Console.WriteLine("");
                return base.Handle(purchase_);
            }
        }
    }
}
