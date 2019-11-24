using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.StackImplementation.LinkedList;

namespace ProblemSolving.Tests.LinkedList
{
    [TestClass]
    public class LinkedListTests
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
        [ExpectedException(typeof(InvalidOperationException))]
        public void Stack_PushItem_ThrowsException_WhenStackUnderflows()
        {
            Stack<int> stack = new Stack<int>();
            stack.Pop();
        }

        [TestMethod]
        public void Stack_PeekItem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);

            Assert.AreEqual(100, stack.Peek());
        }
    }
}