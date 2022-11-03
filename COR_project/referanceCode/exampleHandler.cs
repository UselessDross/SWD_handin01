using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanceCode
{
    class exampleHandler : AbstractHandler
    {
        private string _subject;
        public exampleHandler(string subject)
        {
            _subject = subject;
        }

        public override object Handle(object request)
        {
            if((request as string) == _subject)
            {
                return $"This chain handles {request.ToString()}\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
