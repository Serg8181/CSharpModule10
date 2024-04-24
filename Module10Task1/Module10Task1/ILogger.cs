using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10Task1
{
    internal interface ILogger
    {
        void Error(string text);
        void Event(string text);
       
    }
}
