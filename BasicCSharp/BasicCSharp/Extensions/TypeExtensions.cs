using System;
using System.Reflection;

namespace BasicCSharp.Extensions
{
    internal static class TypeExtensions
    {
        public static bool HasDefaultConstructor(this object instance)
        {
            if (instance == null)
            {
                return false;
            }

            Type type = instance.GetType();

            const BindingFlags bindingFlags = 
                BindingFlags.CreateInstance | 
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic;

            ConstructorInfo constructorInfo = type.GetConstructor(
                bindingFlags,
                null,
                CallingConventions.Any,
                new Type[0],
                new ParameterModifier[0]);

            return constructorInfo != null;
        }

        public static bool HasInstanceMethod(this object instance, string methodName, Type[] argumentTypes)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            Type type = instance.GetType();

            const BindingFlags bindingFlags =
                BindingFlags.InvokeMethod |
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic;

            MethodInfo methodInfo = type.GetMethod(
                methodName,
                bindingFlags,
                null,
                argumentTypes,
                null);

            return methodInfo != null;
        }

        public static Type GetPropertyType(this object instance, string propertyName)
        {
            if (instance == null)
            {
                throw new ArgumentNullException("instance");
            }

            Type type = instance.GetType();

            const BindingFlags bindingFlags =
                BindingFlags.GetProperty |
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic;

            PropertyInfo propertyInfo = type.GetProperty(propertyName, bindingFlags);

            return propertyInfo.PropertyType;
        }
    }
}