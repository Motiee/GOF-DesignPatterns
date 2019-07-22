using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
  public class Singleton <T> where T:class,new()
    {
      private static readonly T UniqueInstance = new T();

        private Singleton()
        {

        }

        public static T Instance()
        {
            return UniqueInstance;
        }
    }
}
