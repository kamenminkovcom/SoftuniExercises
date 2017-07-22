using System.Collections.Generic;

public class AddCollection<T> : IAdd<T>
{
    public AddCollection()
    {
        Collection = new List<T>();
        Adds = new List<int>();
    }

    public List<T> Collection { get; }

    public List<int> Adds { get; }

    public virtual int Add(T element)
    {
        Collection.Add(element);
        int index = Collection.Count - 1;
        Adds.Add(index);    
        return index;
    }
}

