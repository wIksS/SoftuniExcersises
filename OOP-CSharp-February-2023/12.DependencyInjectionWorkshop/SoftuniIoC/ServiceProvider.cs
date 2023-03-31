using SoftuniIoC.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IServiceProvider = SoftuniIoC.Contracts.IServiceProvider;

namespace SoftuniIoC
{
    public class ServiceProvider : SoftuniIoC.Contracts.IServiceProvider
    {
        private IServiceCollection serviceCollection;

        public ServiceProvider(IServiceCollection serviceCollection)
        {
            this.serviceCollection = serviceCollection;
        }

        // GetService<IPromotionSerivce> -> PromotionService
        // IDateProvider
        public T GetService<T>()
        {
            return (T)GetService(typeof(T));
        }

        public object GetService(Type type)
        {
            Type implementationType = serviceCollection.GetMapping(type);
            Func<IServiceProvider, object> instantiationFunc = serviceCollection.GetInstantiationFunc(type);

            if (instantiationFunc != null)
            {
                return instantiationFunc(this);
            }

            ConstructorInfo constructor = implementationType.GetConstructors()[0];
            // IDateProvider
            ParameterInfo[] parameters = constructor.GetParameters();
            object[] parameterObjects = new object[parameters.Length];
            int index = 0;
            foreach (var parameter in parameters)
            {
                //IDateProvider
                parameterObjects[index++] = GetService(parameter.ParameterType);
            }

            return constructor.Invoke(parameterObjects);
        }
    }
}
