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

            public override object Handle(Purchase purchase_)
            {
                if (purchase_.amount < 25000.0)
                {
                    return ("{0} approved request# {1}", this.GetType().Name, purchase_.number);
                }
                else
                {
                    CheckEnd(purchase_);
                    Console.WriteLine("'SHHHSSss... I am NOT taking responsibility for this'");
                    Console.WriteLine("'the president can have the choice to approve it or not.'");
                    Console.WriteLine("*sends it to the President*");
                    return base.Handle(purchase_);
                }
            }
      }
    
}
