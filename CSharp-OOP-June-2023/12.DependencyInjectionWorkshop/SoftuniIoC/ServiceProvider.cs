using System.Reflection;

namespace SoftuniIoC
{
    public class ServiceProvider
    {
        private ServiceCollection mappings;
        private Dictionary<Type, object> instances;

        public ServiceProvider(ServiceCollection mappings)
        {
            this.mappings = mappings;
            instances = new Dictionary<Type, object>();
        }

        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        private object GetService(Type type)
        {
            if (instances.ContainsKey(type))
            {
                return instances[type];
            }

            Type implementationType = mappings.GetMapping(type);

            if (mappings.HasFactory(type))
            {
                Func<ServiceProvider, object> factory = mappings.GetFactory(type);

                return factory(this);
            }

            ConstructorInfo[] constructors = implementationType.GetConstructors();

            object[] inputs = null;

            if (constructors.Length > 0)
            {
                ConstructorInfo constructor = constructors[0];
                ParameterInfo[] parameters = constructor.GetParameters();
                inputs = new object[parameters.Length];
                int index = 0;

                foreach (ParameterInfo parameter in parameters)
                {
                    inputs[index++] = this.GetService(parameter.ParameterType);
                }
            }
            var instance = Activator.CreateInstance(implementationType, inputs);

            if (mappings.IsSingleton(type) == true)
            {
                instances[type] = instance;
            }

            return instance;
        }
    }
}