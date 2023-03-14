using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWorkshop
{
    public class Serializator
    {
        public static void Save(object obj)
        {
            Type type = obj.GetType();
            StringBuilder result = new StringBuilder();

            foreach (var prop in type.GetProperties())
            {
                result.Append($"{prop.Name}:{prop.GetValue(obj)}|-|");
            }

            using (StreamWriter writer = new StreamWriter($"../../../{type.Name}.txt"))
            {
                writer.Write(result.ToString());
            }
        }

        public static T Load<T>()
        {

            Type type = typeof(T);
            if (!File.Exists($"../../../{type.Name}.txt"))
            {
                return default(T);
            }

            string data = "";

            using (StreamReader writer = new StreamReader($"../../../{type.Name}.txt"))
            {
                data = writer.ReadToEnd();
            }


            string[] props = data.Split("|-|", StringSplitOptions.RemoveEmptyEntries);

            T obj = (T)Activator.CreateInstance(type);


            foreach (var propPair in props)
            {
                string[] splittedProp = propPair.Split(":");
                var propInfo = type.GetProperty(splittedProp[0]);

                propInfo.SetValue(obj, Convert.ChangeType(splittedProp[1], propInfo.PropertyType) );
            }

            return obj;
        }


    }
}
