using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanceCode
{
    class exampleHandler : AbstractHandler
    {
        public string LinkName; //<-- not nessesary
        private string _subject; //<-- not nessesary
        private int num_;
        public exampleHandler(string subject, string linkName,int num) //<-- not nessesary, all just for the porpus of explaning the pattern
        {
            _subject = subject;
            LinkName = linkName;
            num_ = num;
        }

        public override object Handle(object request)
        {
            Console.SetCursorPosition(num_*10, 4);                 //<-- not nessesary
            Console.Write($"[{LinkName}]->");                      //<-- not nessesary
            Console.SetCursorPosition(0, 8);                       //<-- not nessesary
            if ((request as string) == _subject) 
            {
                Console.SetCursorPosition(num_ * 10, 3);           //<-- not nessesary
                Console.ForegroundColor = ConsoleColor.DarkYellow; //<-- not nessesary
                Console.Write($"[{LinkName}]  ");                  //<-- not nessesary
                Console.ForegroundColor = ConsoleColor.White;      //<-- not nessesary
                Console.SetCursorPosition(((num_+1) * 10), 4);     //<-- not nessesary
                Console.SetCursorPosition(0, 5);                   //<-- not nessesary
                return $"This link, {LinkName} handles {request.ToString()}\n";
            }
            else
            {
                CheckEnd(request);                                 //<-- not nessesary

                return base.Handle(request);
            }
        }



        
    }

}
