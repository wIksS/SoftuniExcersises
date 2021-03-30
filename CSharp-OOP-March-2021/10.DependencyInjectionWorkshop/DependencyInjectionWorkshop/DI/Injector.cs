using DependencyInjectionWorkshop.DI.Attributes;
using DependencyInjectionWorkshop.DI.Containers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DependencyInjectionWorkshop.DI
{
    public class Injector
    {
        private IContainer container;

        public Injector(IContainer container)
        {
            this.container = container;
        }

        public TClass Inject<TClass>()
        {
            if (!HasConstructorInjection<TClass>())
            {
                return (TClass)Activator.CreateInstance(typeof(TClass));
                //throw new ArgumentException("The class has no constructor annoted with the [Inject] attribute");
            }

            return CreateConstructorInjection<TClass>();
        }

        private TClass CreateConstructorInjection<TClass>()
        {
            ConstructorInfo[] constructors = typeof(TClass).GetConstructors();

            if (constructors.Length > 1)
            {
                throw new ArgumentException("Only one constructor is allowed");
            }

            foreach (ConstructorInfo constructor in constructors)
            {
                //if (constructor.GetCustomAttribute(typeof(Inject), true) == null)
                //{
                //    continue;
                //}

                ParameterInfo[] constructorParams = constructor.GetParameters();
                object[] constructorParamObjects = new object[constructorParams.Length];
                int i = 0;
                foreach (ParameterInfo paramInfo in constructorParams)
                {
                    object implementationInstance = GetImplementation(paramInfo.ParameterType);

                    constructorParamObjects[i++] = implementationInstance;
                }

                return (TClass)Activator.CreateInstance(typeof(TClass), constructorParamObjects);
            }

            return default;
        }

        private bool HasConstructorInjection<TClass>()
        {
            return typeof(TClass).GetConstructors()
                .Any(c => c.GetParameters().Length != 0);
        }

        private object CallGenericMethod(Type type)
        {
            MethodInfo injectMethod = typeof(Injector).GetMethod("Inject");
            injectMethod = injectMethod.MakeGenericMethod(type);

            return injectMethod.Invoke(this, new object[] { });
        }

        private object GetImplementation(Type type)
        {
            Type interfaceType = type;
            Type implementationType = container.GetMapping(interfaceType);
            object implementationInstance;
            if (implementationType == null)
            {
                var implmentationPair = container.GetCustomMapping(interfaceType);
                implementationInstance = implmentationPair.Value();
            }
            else
            {
                implementationInstance = CallGenericMethod(implementationType);
            }

            return implementationInstance;
        }
    }
}
