using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_project.ConcreetHandlers
{
    /*example and general idea from: https://www.dofactory.com/net/chain-of-responsibility-design-pattern*/
    /* this class has been modified to better let the user understand what is happening*/
    class President : AbstractApprover
    {
        private int MAX_AMOUNT = 100000;
        public override object Handle(Purchase purchase_)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("{0} ", this.GetType().Name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("exsamins request# {0}", purchase_.number);

            if (purchase_.amount < MAX_AMOUNT)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("{0} ", this.GetType().Name);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("approved request# {0}", purchase_.number);
                return (" ");
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("'OOHHhh... I can't approve this!'");
                Console.WriteLine("'BUUUT? If I hold an extra boring executive meeting, that could have been an email'");
                Console.WriteLine("'Then they won't blame ME for it. hehe.'");
                return "MEETING!"; Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
