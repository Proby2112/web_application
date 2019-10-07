using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApplication.Core.Helpers.Core
{
    public static class Extensions
    {
        public static bool Exist<T>(this T obj)
            where T : class
        {
            return obj != null;
        }

        public static bool Exist<T>(this IEnumerable<T> obj)
            where T : class
        {
            return obj?.Any() == true;
        }

        public static bool IsEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}
