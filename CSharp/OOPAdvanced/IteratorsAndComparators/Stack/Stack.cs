namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {

        private List<T> storage;

        public Stack()
        {
            storage = new List<T>();
        }

        public Stack(List<T> initialElements)
        {
            storage = initialElements;
        }

        public void Push(T element)
        {
            storage.Add(element);
        }

        public T Pop()
        {
            int stackCount = storage.Count;
            if (stackCount == 0)
                throw new InvalidOperationException();
            T element = storage[stackCount - 1];
            storage.RemoveAt(stackCount - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = storage.Count - 1; i >= 0; i--)
            {
                yield return storage[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
