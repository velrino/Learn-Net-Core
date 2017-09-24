using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hwapp.Learn.Extensions
{
    static class Lambda
    {
        public static List<int> ListFilter(this List<int> list, int n)
        {
            return list.Where(x => x > n).ToList();
        }
    }
}
