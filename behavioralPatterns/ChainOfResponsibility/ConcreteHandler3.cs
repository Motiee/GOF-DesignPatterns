using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class ConcreteHandler3 : Handler
    {
        public ConcreteHandler3(Handler successor = null) : base(21, 30, successor) { }
    }
}
