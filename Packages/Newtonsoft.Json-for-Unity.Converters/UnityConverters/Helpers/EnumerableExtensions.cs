﻿using System.Collections.Generic;

namespace Newtonsoft.Json.UnityConverters.Helpers
{
    internal static class EnumerableExtensions
    {
        internal static IEnumerable<T> WhereNotNullRef<T>(this IEnumerable<T> values)
            where T : class
        {
            foreach (T item in values)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        internal static IEnumerable<T> WhereNotNullValue<T>(this IEnumerable<T?> values)
            where T : struct
        {
            foreach (T? item in values)
            {
                if (item.HasValue)
                {
                    yield return item.Value;
                }
            }
        }
    }
}
