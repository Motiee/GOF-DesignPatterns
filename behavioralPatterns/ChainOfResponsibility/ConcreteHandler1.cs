using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
    class ConcreteHandler1:Handler
    {
        public ConcreteHandler1(Handler successor = null) : base(1, 10, successor) { }
    }
}
