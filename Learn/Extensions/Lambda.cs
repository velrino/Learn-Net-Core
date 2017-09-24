using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hwapp.Learn.Extensions
{
    class Lambda
    {
        public static IEnumerable<int> ListFilter()
        {
            var list = new List<int>() {1,2,3,4,5,6,7,8}.Where(x => x > 4);
            list.ToList().ForEach(n => Console.WriteLine(n));
            return list;
        }
    }
}
