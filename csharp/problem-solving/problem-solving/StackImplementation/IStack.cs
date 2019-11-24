using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.StackImplementation
{
    interface IStack<T>
    {
        int Count { get; }
        T Peek();
        T Pop();
        void Push(T item);
        bool IsEmpty();
    }

    interface IArrayBasedStack<T> : IStack<T>
    {
        bool IsFull();
    }
}
