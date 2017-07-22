using System;

public class MyList<T> : AddRemoveCollection<T>
{
    public int Used => Collection.Count;
    
    public override T Remove()
    {
        if (Collection.Count == 0)
            throw new InvalidOperationException("The list is empty");
        T element = Collection[0];
        Collection.RemoveAt(0);
        Removes.Add(element);
        return element;
    }
}

