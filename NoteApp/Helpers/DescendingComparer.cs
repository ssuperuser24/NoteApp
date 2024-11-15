﻿namespace NoteApp.Helpers;

/// <summary>
/// Compare objects for descending order
/// </summary>
/// <typeparam name="T"></typeparam>
public class DescendingComparer<T> : IComparer<T>
{
    public int Compare(T? x, T? y)
    {
        if (x == null) return -1;
        if (y == null) return 1;
        return Comparer<T>.Default.Compare(y, x);
    }
}