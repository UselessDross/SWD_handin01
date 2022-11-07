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
        public override object Handle(Purchase purchase_)
        {
            if (purchase_.amount < 100000.0)
            {
                return ("{0} approved request# {1}", this.GetType().Name, purchase_.number);
            }
            else
            { 
                Console.WriteLine("'OOHHhh... I can't approve this!'");
                Console.WriteLine("'BUUUT? If I Hold an extra boring executive meeting, that could have been an email'");
                Console.WriteLine("'Then they won't blame ME for it. hehe.'");
                return "MEETING!";
            }
        }
    }
}
