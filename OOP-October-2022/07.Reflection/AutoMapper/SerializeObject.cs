using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AutoMapper
{
    internal class SerializeObject
    {
        public string Serialize(object obj)
        {
            StringBuilder sb = new StringBuilder();
            Type type = obj.GetType();

            PropertyInfo[] props = type.GetProperties();

            foreach (PropertyInfo prop in props)
            {
                sb.Append($"{prop.Name}:{prop.GetValue(obj)}|");
            }

            sb.Append("&&|&&");
            return sb.ToString();
        }

        public T Deserialize<T>(string productAsString)
        {
            Type type = typeof(T);
            T newObject = (T)Activator.CreateInstance(type);
            var fields = productAsString.Split("|", StringSplitOptions.RemoveEmptyEntries);
            foreach (var field in fields)
            {
                var splittedField = field.Split(":");
                PropertyInfo prop = type.GetProperty(splittedField[0]);

                if (prop.PropertyType == typeof(decimal))
                {
                    prop.SetValue(newObject, decimal.Parse(splittedField[1]));
                }
                else
                {
                    prop.SetValue(newObject, splittedField[1]);
                }
            }

            return newObject;
        }
    }
}
