using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COR_project
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(Purchase request);
    }
}
