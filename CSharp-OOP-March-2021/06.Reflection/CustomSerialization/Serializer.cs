using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CustomSerialization
{
    class Serializer
    {

        public static string ToJson(object obj, int identationAmount)
        {
            if (obj == null)
            {
                return "\"\"";
            }
            string identationBase = new string(' ', identationAmount);

            string identation = new string(' ', identationAmount + 3);
            StringBuilder json = new StringBuilder();
            json.Append($"{identationBase}{{\n");
            Type type = obj.GetType();

            foreach (var property in type.GetProperties((BindingFlags)60))
            {
                string name = property.Name;
                object value = property.GetValue(obj);

                if (property.PropertyType.IsClass &&
                    property.PropertyType.Assembly.FullName == type.Assembly.FullName)
                {
                    value = ToJson(property.GetValue(obj), identationAmount + 3);
                }
                else if (!typeof(String).Equals(property.PropertyType) && 
                    typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                {
                    var x = property.GetValue(obj);
                    IEnumerable objects =(IEnumerable) x;
                    value = "[";
                    foreach (var item in objects)
                    {
                        value += item + ",";
                    }
                    value += "]";
                }

                json.Append($"{identation}\"{name}\":{value}\n");
            }


            json.Append($"{identationBase}}}");
            return json.ToString();
        }
    }
}
