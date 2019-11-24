using System;
using ProblemSolving.LinkedListImplementation.Singly;

namespace ProblemSolving.StackImplementation.LinkedList
{
    public class Stack<T> : IStack<T>
    {
        private readonly LinkedList<T> _items = new LinkedList<T>();

        public int Count { get; private set; }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            return _items.Last.Value;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack was empty.");
            }

            var item = _items.RemoveLast().Value;
            Count--;
            return item;
        }

        public void Push(T item)
        {
            Count++;
            _items.AddLast(item);
        }
    }
}