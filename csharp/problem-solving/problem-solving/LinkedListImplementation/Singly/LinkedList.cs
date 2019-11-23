using System;

namespace ProblemSolving.LinkedListImplementation.Singly
{
    public class LinkedList<T>
    {
        private Node<T> _head;

        private Node<T> CreateNode(T value)
        {
            return new Node<T>(value);
        }

        public void AddLast(T value)
        {
            var newNode = CreateNode(value);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            var currentNode = _head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
        }

        public void Traverse()
        {
            var currentNode = this._head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public void AddAfter(T value, T newValue)
        {
            var newNode = CreateNode(newValue);

            var currentNode = _head;

            while (!currentNode.Value.Equals(value))
            {
                currentNode = currentNode.Next;
            }

            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
        }

        public void AddBefore(T value, T newValue)
        {
            var newNode = CreateNode(newValue);

            var currentNode = _head;
            var previousNode = currentNode;

            while (!currentNode.Value.Equals(value))
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            newNode.Next = previousNode.Next;
            previousNode.Next = newNode;
        }

        public void AddFirst(T value)
        {
            var newNode = CreateNode(value);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            newNode.Next = _head;
            _head = newNode;
        }

        public void Clear()
        {
            var currentNode = _head;
            var previousNode = _head;

            while (currentNode.Next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                previousNode.Value = default(T);
                previousNode.Next = null;
            }

            _head = null;
        }

        public void Remove(T value)
        {
            var currentNode = _head;
            var previousNode = _head;

            if (_head.Value.Equals(value))
            {
                _head = _head.Next;
                return;
            }

            while (!currentNode.Value.Equals(value))
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            previousNode.Next = previousNode.Next.Next;
        }

        public void RemoveFirst()
        {
            var tempNode = _head;
            _head = _head.Next;
        }

        public void RemoveLast()
        {
            var currentNode = _head;
            var previousNode = _head;

            while (currentNode.Next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            previousNode.Next = null;
        }
    }

    internal class Node<T>
    {
        public Node<T> Next;
        public T Value;

        public Node(T value)
        {
            this.Value = value;
        }
    }
}