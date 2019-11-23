using System;

namespace ProblemSolving.LinkedListImplementation.Singly
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> _head;

        public int Count { get; private set; }

        public LinkedListNode<T> First
        {
            get { return _head; }
        }

        public LinkedListNode<T> Last
        {
            get
            {
                var currentNode = _head;

                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode;
            }
        }

        public void AddAfter(T value, T newValue)
        {
            Count++;

            var newNode = CreateNode(newValue);

            var currentNode = _head;

            while (currentNode!=null && !currentNode.Value.Equals(value))
            {
                currentNode = currentNode.Next;
            }

            if (currentNode == null || !currentNode.Value.Equals(value))
            {
                throw new LinkedListNodeNotFoundException("Node not found.");
            }

            newNode.Next = currentNode.Next;
            currentNode.Next = newNode;
        }

        public void AddBefore(T value, T newValue)
        {
            Count++;

            var newNode = CreateNode(newValue);

            var currentNode = _head;
            LinkedListNode<T> previousNode = _head;

            while (currentNode!=null && !currentNode.Value.Equals(value))
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            if (currentNode == null ||
                previousNode == null ||
                !currentNode.Value.Equals(value))
            {
                throw new LinkedListNodeNotFoundException("Node not found.");
            }

            newNode.Next = previousNode.Next;

            if (Count == 2)
            {
                _head = newNode;
            }
        }

        public void AddFirst(T value)
        {
            Count++;

            var newNode = CreateNode(value);

            if (_head == null)
            {
                _head = newNode;
                return;
            }

            newNode.Next = _head;
            _head = newNode;
        }

        public void AddLast(T value)
        {
            var newNode = CreateNode(value);

            Count++;

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
            Count = 0;
        }

        public void Remove(T value)
        {
            Count--;
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
            if (_head==null)
            {
                throw new LinkedListNodeNotFoundException("");
            }
            Count--;

            var tempNode = _head;
            _head = _head.Next;
        }

        public void RemoveLast()
        {
            if (_head == null)
            {
                throw new LinkedListNodeNotFoundException("");
            }

            Count--;

            var currentNode = _head;
            var previousNode = _head;

            while (currentNode.Next != null)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
            }

            previousNode.Next = null;
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

        private LinkedListNode<T> CreateNode(T value)
        {
            return new LinkedListNode<T>(value);
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next;
        public T Value;

        public LinkedListNode(T value)
        {
            this.Value = value;
        }
    }
}