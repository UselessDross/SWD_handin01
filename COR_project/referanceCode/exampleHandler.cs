using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanceCode
{
    class exampleHandler : AbstractHandler
    {
        public string LinkName; //<-- not necessary
        private string _subject; //<-- not necessary
        private int num_;
        public exampleHandler(string subject, string linkName,int num) //<-- not necessary, all just for the porpus of explaning the pattern
        {
            _subject = subject;
            LinkName = linkName;
            num_ = num;
        }

        public override object Handle(object request)
        {
            Console.SetCursorPosition(num_*10, 4);                 //<-- not necessary
            Console.Write($"[{LinkName}]->");                      //<-- not necessary
            Console.SetCursorPosition(0, 8);                       //<-- not necessary
            if ((request as string) == _subject) 
            {
                Console.SetCursorPosition(num_ * 10, 3);           //<-- not necessary
                Console.ForegroundColor = ConsoleColor.DarkYellow; //<-- not necessary
                Console.Write($"[{LinkName}]  ");                  //<-- not necessary
                Console.ForegroundColor = ConsoleColor.White;      //<-- not necessary
                Console.SetCursorPosition(((num_+1) * 10), 4);     //<-- not necessary
                Console.SetCursorPosition(0, 5);                   //<-- not necessary
                return $"This link, {LinkName} handles {request.ToString()}\n";
            }
            else
            {
                CheckEnd(request);                                 //<-- not necessary

                return base.Handle(request);
            }
        }



        
    }

}
