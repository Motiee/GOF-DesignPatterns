using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Bridge
{
    public  static class Implementation
    {
        public static Implementor GetImplementation()
        {
            var config = ConfigurationManager.AppSettings;
          
            switch (config["Implementor"])
            {
                case "ConcreteImplementorA":
                    return  new ConcreteImplementorA();
                case "ConcreteImplementorB":
                   return  new ConcreteImplementorB();
                default:
                    return  new DefaultImplementation();
               
            }

        }
    
    }
}
