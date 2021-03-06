﻿using System.Collections.Generic;
using System.Text;

namespace EmitMapper.Utils
{
    internal static class MiscUtils
    {
        public static string ToCSV<T>(this IEnumerable<T> collection, string delim)
        {
            if (collection == null)
            {
                return "";
            }

            var result = new StringBuilder();
            foreach (var value in collection)
            {
                result.Append(value);
                result.Append(delim);
            }
            if (result.Length > 0)
            {
                result.Length -= delim.Length;
            }
            return result.ToString();
        }
    }
}