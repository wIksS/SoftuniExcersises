using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace PrototypePattern
{
    public class DeepCloner
    {
        public static T DeepClone<T>(T a)
        {
            var obj = JsonConvert.SerializeObject(a);

            return JsonConvert.DeserializeObject<T>(obj);
        }

        //public static T DeepClone<T>(T a)
        //{
        //    using (MemoryStream stream = new MemoryStream())
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(stream, a);
        //        stream.Position = 0;
        //        return (T)formatter.Deserialize(stream);
        //    }
        //}

    }
}
