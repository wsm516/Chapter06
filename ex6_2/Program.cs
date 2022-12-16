using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
  
namespace ex6_2
{
    internal class Program
    {
        interface IGenericInterface<T>
        {
            void SetValue(T x);
            string GetValueType();
        }
        class GenericClass<T> : IGenericInterface<T>
        {
            private T value;
            public void SetValue(T x)
            {
                value = x;
            }
            public String GetValueType()
            {
                return value.GetType().ToString();
            }
        }
        static void Main(string[] args)
        {
            GenericClass<Int32> gInteger = new GenericClass<Int32>();
            GenericClass<String> gString = new GenericClass<String>();
            gInteger.SetValue(10);
            gString.SetValue("Text");
            Console.WriteLine(gInteger.GetValueType());
            Console.WriteLine(gString.GetValueType());

        }
    }
}
