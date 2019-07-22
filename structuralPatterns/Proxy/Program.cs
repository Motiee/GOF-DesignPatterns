using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy
{
    class Program
    {

        public static void UseSubject(Subject subject)
        {
            subject.Request();
        }
        static void Main(string[] args)
        {
            Subject proxy=new SubjectProxy();
            UseSubject(proxy);

            Console.ReadKey();
        }
    }
}
