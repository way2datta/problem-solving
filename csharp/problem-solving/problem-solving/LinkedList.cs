using System.Collections.Generic;

namespace ProblemSolving
{
    public class LinkedList<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            var newNode = new LinkedListNode<T>() { Value = value };

            if (head == null)
            {
                tail = head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

            Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new LinkedListNode<T>() { Value = value };

            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public T First()
        {
            return head != null ? head.Next.Value : default(T);
        }

        public T Last()
        {
            return tail != null ? tail.Next.Value : default(T);
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }

            var temp = head;
            head = head.Next;

            if (Count == 1)
            {
                tail = head;
            }
            Count--;
        }

        public IEnumerable<LinkedListNode<T>> GetEnumerator()
        {
            var currentNode = head;

            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Next;
            }
        }
    }

    public class LinkedListNode<T>
    {
        public LinkedListNode<T> Next { get; set; }
        public T Value { get; set; }
    }
}