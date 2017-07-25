using System;
using System.Collections.Generic;

public class Box<T> : IComparable
{
    public Box(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }

    public override string ToString() =>  Value.GetType().FullName + ": " + Value;

    public int CompareTo(object obj)
    {
        return Comparer<T>.Default.Compare(Value, (T)obj);
    }
}

