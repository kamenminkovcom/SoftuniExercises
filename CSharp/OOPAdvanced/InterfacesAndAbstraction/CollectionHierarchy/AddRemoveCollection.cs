using System.Collections.Generic;

public class AddRemoveCollection<T> : AddCollection<T>, IRemove<T>
{
    public AddRemoveCollection()
    {
        Removes = new List<T>();
    }

    public List<T> Removes { get; }

    public virtual T Remove()
    {
        int index = Collection.Count - 1;
        T element = Collection[index];
        Collection.RemoveAt(index);
        Removes.Add(element);
        return element;
    }

    public override int Add(T element)
    {
        Collection.Insert(0, element);
        Adds.Add(0);
        return 0;
    }
}

