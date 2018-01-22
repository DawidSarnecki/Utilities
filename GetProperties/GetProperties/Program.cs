using System;
using System.Collections.Generic;
using System.Reflection;

namespace GetProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var program = new Test();
            PropertyInfo[] properties = program.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                var defaultValue = property.PropertyType.GetDefaultValue();
                var actualValue = property.GetValue(program);

                Console.WriteLine($"{property.Name}= {property.GetValue(program)}");
                Console.WriteLine($"{property.Name}, defaultValue={defaultValue}, actualValue={actualValue}");

                /// ref: https://stackoverflow.com/questions/65351/null-or-default-comparison-of-generic-argument-in-c-sharp
                //ool comparer = EqualityComparer<T>.Default.Equals(actualValue, default(T))
            }
        }

        /// ref: https://stackoverflow.com/questions/65351/null-or-default-comparison-of-generic-argument-in-c-sharp
        public void MyMethod<T>(T myArgument) where T : Type
        {

        }



        /// ref: https://stackoverflow.com/questions/2490244/default-value-of-a-type-at-runtime
        object GetDefaultValue(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }
    }

    //ref: https://stackoverflow.com/questions/2490244/default-value-of-a-type-at-runtime
    public static class TypeExtensions
    {
        public static object GetDefaultValue(this Type t)
        {
            if (t.IsValueType && Nullable.GetUnderlyingType(t) == null)
                return Activator.CreateInstance(t);
            else
                return null;
        }
    }
}
