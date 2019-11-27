using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.QueueImplementation.Array
{
    public class Queue<T> : IQueue<T>
    {
        static int DefaultCapacity = 5;
        int _front, _back;
        T[] _items;

        public Queue() : this(DefaultCapacity)
        {
        }

        public Queue(int initialCapacity)
        {
            _front = 0;
            _back = 0;
            _items = new T[initialCapacity];
        }

        public T Front()
        {
            if(IsEmpty())
            {
                throw new QueueException("Queue is empty.");
            }
            return _items[_front];
        }

        public bool IsEmpty()
        {
            return _front == _back;
        }

        public object Back()
        {
            if (IsEmpty())
            {
                throw new QueueException("Queue is empty.");
            }
            return _items[_back-1];
        }

        public void Enqueue(T value)
        {
            if (IsFull())
            {
                throw new QueueException("Queue is full.");
            }

            _items[_back++] = value;
        }

        public bool IsFull()
        {
            return _items.Length == _back;
        }

        public T Dequeue()
        {
            var itemToRemove = Front();
            _items[_front++] = default(T);
            return itemToRemove;
        }
    }
}
