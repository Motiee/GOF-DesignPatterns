using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
   public static class ServiceLocator
    {
        private readonly static Dictionary<Type, object> services = new Dictionary<Type, object>();
        public static T GetService<T>()
        {
            return (T)ServiceLocator.services[typeof(T)];
        }
        public static void Register<T>(T Service)
        {
         ServiceLocator.services[typeof(T)]=Service;
        }
        public static void Reset()
        {
            ServiceLocator.services.Clear();
        }



    }
}
