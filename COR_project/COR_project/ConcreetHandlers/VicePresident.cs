using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_project.ConcreetHandlers
{
    /*example and general idea from: https://www.dofactory.com/net/chain-of-responsibility-design-pattern*/
    /* this class has been modified to better let the user understand what is happening*/
     class VicePresident : AbstractApprover
    {
        private int MAX_AMOUNT = 25000;

            public override object Handle(Purchase purchase_)
            {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("{0} ", this.GetType().Name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("exsamins request# {0}", purchase_.number);
            if (purchase_.amount < MAX_AMOUNT)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("{0} ", this.GetType().Name);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("approved request# {0}", purchase_.number);
                    return (" ");
                }
                else
                {
                    CheckEnd(purchase_);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("'SHHHSSss... I am NOT taking responsibility for this'");
                    Console.WriteLine("'the president can have the choice to approve it or not.'");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("*sends request# {0} to the President*", purchase_.number);

                return base.Handle(purchase_);
                }
            }


      
    }
    
}
