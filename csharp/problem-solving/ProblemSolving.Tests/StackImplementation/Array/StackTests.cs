using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.StackImplementation.Array.Tests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void Stack_IsEmpty_WhenInialized()
        {
            Stack<int> stack = new Stack<int>();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void Stack_PushItem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            Assert.AreEqual(1, stack.Count);
        }

        [TestMethod]
        public void Stack_PopItem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);
            var item = stack.Pop();
            Assert.AreEqual(100, item);
        }

        [TestMethod]
        public void Stack_IsFull()
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(100);
            stack.Push(200);

            Assert.IsTrue(stack.IsFull());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Stack_PushItem_ThrowsException_WhenStackOverflows()
        {
            Stack<int> stack = new Stack<int>(1);
            stack.Push(100);
            stack.Push(200);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Stack_PushItem_ThrowsException_WhenStackUnderflows()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Stack_PeekItem_ThrowsException_WhenStackUnderflows()
        {
            Stack<int> stack = new Stack<int>();
            stack.Peek();
        }

        [TestMethod]
        public void Stack_PeekItem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);

            Assert.AreEqual(100, stack.Peek());
        }

        [TestMethod]
        public void Stack_CharacterizationTests()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.IsTrue(stack.IsEmpty());
            Assert.ThrowsException<InvalidOperationException>(() => { stack.Peek(); });
            Assert.ThrowsException<InvalidOperationException>(() => { stack.Pop(); });

            stack.Push(100);

            Assert.AreEqual(100, stack.Peek());

            stack.Push(200);
            stack.Push(300);

            Assert.IsTrue(stack.IsFull());

            Assert.AreEqual(300, stack.Pop());
            Assert.AreEqual(200, stack.Pop());
            Assert.AreEqual(100, stack.Pop());
            Assert.IsTrue(stack.IsEmpty());
        }
    }
}