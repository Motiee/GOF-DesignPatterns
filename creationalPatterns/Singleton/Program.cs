using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc1 = Singleton<MyClass>.Instance();
            MyClass mc2 = Singleton<MyClass>.Instance();

            HisClass hc1 = Singleton<HisClass>.Instance();
            HisClass hc2 = Singleton<HisClass>.Instance();

            if(mc1==mc2)
                Console.WriteLine("mc1 and mc2 refer to the same instance");
            else
            
                Console.WriteLine("mc1 and mc2 distinct instance");

            if (hc1 == hc2)
                Console.WriteLine("hc1 and hc2 refer to the same instance");
            else

                Console.WriteLine("hc1 and hc2 distinct instance");

            Console.ReadKey();

        }
    }
}
