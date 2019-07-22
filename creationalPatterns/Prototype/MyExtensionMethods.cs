using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype
{
   public static class MyExtensionMethods
    {

        public static T DeepClone<T>(this T a)
        {
            using (var stream=new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream,a);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}
