namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private class Node
        {
            public Node(T value)
            {
                Value = value;
            }
            public Node NextNode { get; set; }
            public T Value { get; }
        }

        private Node firstNode;
        private Node lastNode;

        public int Count { get; private set; }

        public LinkedList()
        {
            Count = 0;
        }

        public void Add(T value)
        {
            Node element = new Node(value);
            if (Count == 0)
            {
                firstNode = element;
                lastNode = element;
            }
            else
            {
                lastNode.NextNode = element;
                lastNode = lastNode.NextNode;
            }
            Count++;
        }

        public bool Remove(T value)
        {
            if (Count == 0)
                throw new InvalidOperationException();
            Node prevNode = null;
            Node currentNode = firstNode;
            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    if (prevNode == null)
                    {
                        firstNode = currentNode.NextNode;
                    }
                    else
                    {
                        prevNode.NextNode = currentNode.NextNode;
                    }
                    Count--;
                    return true;
                }
                prevNode = currentNode;
                currentNode = currentNode.NextNode;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentElement = firstNode;
            while (currentElement != null)
            {
                yield return currentElement.Value;
                currentElement = currentElement.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString() => string.Join(" ", this);
    }
}
