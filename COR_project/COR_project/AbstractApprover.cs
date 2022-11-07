using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_project
{
    //The abstract handler
    abstract class AbstractApprover : IHandler
    {
        private IHandler _nextApprover = null;

        public virtual object Handle(Purchase request)
        {
            if (this._nextApprover != null)
            {
                return this._nextApprover.Handle(request);
            }
            else
            {
                return null;
            }
        }
        public void CheckEnd(object request) 
        {
            if (_nextApprover == null)
            {
                Console.Write(" The Purchase request '");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{request}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("' was not handled by ANY managers or executives of this chain of comand");
            }
        }


        public IHandler SetNext(IHandler handler)
        {
            this._nextApprover = handler;

            return handler;
        }
    }
}
