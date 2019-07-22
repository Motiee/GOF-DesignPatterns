using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class CarPrototypeManager
    {
        private Dictionary<string,Car>prototypes=new Dictionary<string, Car>();

        public void add(string key , Car car)
        {
            prototypes.Add(key,car);
        }

        public Car CreateCar(string key)
        {
            return prototypes[key].DeepClone<Car>();
        }
    }
}
