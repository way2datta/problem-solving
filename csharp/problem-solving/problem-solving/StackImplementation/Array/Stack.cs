using System;

namespace ProblemSolving.StackImplementation.Array
{
    public class Stack<T> : IArrayBasedStack<T>
    {
        private T[] _items;
        private static int DefaultCapacity = 5;

        public Stack() : this(DefaultCapacity)
        {
        }

        public Stack(int initialCapacity)
        {
            _items = new T[initialCapacity];
        }

        public int Count { get; private set; }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack was empty.");
            }

            return _items[Count - 1];
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack was empty.");
            }

            var item = _items[Count - 1];
            _items[Count - 1] = default(T);
            Count--;

            return item;
        }

        public void Push(T item)
        {
            if (IsFull())
            {
                throw new InvalidOperationException("Stack was full.");
            }
            _items[Count++] = item;
        }

        public bool IsFull()
        {
            return Count == _items.Length;
        }
    }
}