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
                return ("{0} approved request# {1}", GetType().Name, purchase_.number);
            }
            else
            {
                CheckEnd(purchase_);
                Console.WriteLine("'The purchase of this too high for me to aprove'");
                Console.WriteLine("'Better hand it over to the VicePresident'");
                Console.WriteLine("*sends it to the VicePresedent*");
                return base.Handle(purchase_);
            }
        }
    }
}
