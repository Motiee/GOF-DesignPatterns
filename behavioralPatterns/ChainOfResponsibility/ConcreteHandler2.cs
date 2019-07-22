using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class ConcreteHandler2 : Handler
    {
        public ConcreteHandler2(Handler successor = null) : base(11, 20, successor) { }
    }
}
