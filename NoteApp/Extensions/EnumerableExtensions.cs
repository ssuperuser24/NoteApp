﻿namespace NoteApp.Extensions;
public static class EnumerableExtensions
{
    /// <summary>
    /// Get index of the element in enumerable
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="source"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static int IndexOf<T>(this IEnumerable<T> source, T value)
    {
        int index = 0;
        var comparer = EqualityComparer<T>.Default; // or pass in as a parameter
        foreach (T item in source)
        {
            if (comparer.Equals(item, value)) return index;
            index++;
        }
        return -1;
    }
}
