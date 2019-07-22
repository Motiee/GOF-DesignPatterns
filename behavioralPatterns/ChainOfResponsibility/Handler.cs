using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResponsibility
{
   abstract class Handler
    {
        protected Handler successor;
        protected int from;
        protected int to;

        public Handler(int from,int to,Handler successor)
        {
            this.successor = successor;
            this.from = from;
            this.to = to;
        }

        public virtual void HandleRequest(int request)
        {
            if (request >= this.from && request < this.to)
                Console.WriteLine("{0} handled request for {1}", this.GetType().Name, request);
            else if (successor != null)
                successor.HandleRequest(request);
            else
                Console.WriteLine("Request for {0} can not be handled",  request);
        }
    }
}
