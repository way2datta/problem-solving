using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.QueueImplementation;
using ProblemSolving.QueueImplementation.Array;

namespace ProblemSolving.Tests
{
    [TestClass]
    public class QueueUsingArrayTests
    {
        [TestMethod]
        public void Queue_CharacterizationTest()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsTrue(queue.IsEmpty());
            Assert.ThrowsException<QueueException>(() => { queue.Front(); });
            Assert.ThrowsException<QueueException>(() => { queue.Back(); });

            queue.Enqueue(100);
            Assert.AreEqual(queue.Front(), 100);
            Assert.AreEqual(queue.Back(), 100);

            queue.Enqueue(200);
            Assert.AreEqual(queue.Front(), 100);
            Assert.AreEqual(queue.Back(), 200);

            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue(500);

            Assert.AreEqual(queue.Front(), 100);
            Assert.AreEqual(queue.Back(), 500);
            Assert.IsTrue(queue.IsFull());

            int first = queue.Dequeue();
            Assert.AreEqual(first, 100);

            int second = queue.Dequeue();
            Assert.AreEqual(second, 200);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            Assert.IsTrue(queue.IsEmpty());
            Assert.ThrowsException<QueueException>(() => { queue.Dequeue(); });
        }
    }
}