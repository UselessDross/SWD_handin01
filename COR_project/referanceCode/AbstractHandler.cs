using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanceCode
{
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler = null;

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
        public void CheckEnd(object request) //<-- not nessesary
        {
            if (_nextHandler == null)
            {
                Console.Write(" The object '");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write($"{request}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("' was not handled by ANY link of this chain");

            }
        }


        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
      
            return handler;
        }
    }
}
