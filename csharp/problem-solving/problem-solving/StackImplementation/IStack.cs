namespace ProblemSolving.StackImplementation
{
    internal interface IStack<T>
    {
        int Count { get; }

        T Peek();

        T Pop();

        void Push(T item);

        bool IsEmpty();
    }

    internal interface IArrayBasedStack<T> : IStack<T>
    {
        bool IsFull();
    }
}