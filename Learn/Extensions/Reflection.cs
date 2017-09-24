using System;
using System.Collections.Generic;
using System.Text;

namespace hwapp.Learn.Extensions
{
    static class Reflection
    {
        public static object Logers(this object obj)
        {
            var type = obj.GetType();
            var builder = new StringBuilder();
            foreach (var item in type.GetProperties())
                Console.WriteLine(item.Name + " " + item.GetValue(obj));
            return obj;
        }
    }
}
