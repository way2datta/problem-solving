using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProblemSolving.StackImplementation.Array;

namespace ProblemSolving.Tests
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
        public void Stack_PeekItem()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(100);

            Assert.AreEqual(100, stack.Peek());
        }
    }
}