using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.LinkedListImplementation.Singly
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void LinkedList_AddFirst_WhenListIsEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(100);

            Assert.AreEqual(1, linkedList.Count);
            Assert.AreEqual(100, linkedList.First.Value);
        }

        [TestMethod]
        public void LinkedList_AddFirst_WhenListIsNotEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(100);
            linkedList.AddFirst(200);

            Assert.AreEqual(2, linkedList.Count);
            Assert.AreEqual(200, linkedList.First.Value);
        }

        [TestMethod]
        public void LinkedList_AddLast_WhenListIsEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);

            Assert.AreEqual(100, linkedList.Last.Value);
        }

        [TestMethod]
        public void LinkedList_AddLast_WhenListIsNotEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddLast(200);

            Assert.AreEqual(2, linkedList.Count);
            Assert.AreEqual(200, linkedList.Last.Value);
        }

        [TestMethod]
        public void LinkedList_AddAfter_FirstElement()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddAfter(100, 200);

            Assert.AreEqual(2, linkedList.Count);
            Assert.AreEqual(200, linkedList.Last.Value);
        }

        [TestMethod]
        public void LinkedList_AddAfter_LastElement()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddLast(200);
            linkedList.AddAfter(200, 300);

            Assert.AreEqual(3, linkedList.Count);
            Assert.AreEqual(300, linkedList.Last.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(LinkedListNodeNotFoundException))]
        public void LinkedList_AddAfter_ThrowsExceptionWhenSearchNodeIsNotFound()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddLast(200);
            linkedList.AddAfter(400, 300);
        }

        [TestMethod]
        public void LinkedList_AddBefore_FirstElement()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddBefore(100, 200);

            Assert.AreEqual(2, linkedList.Count);
            Assert.AreEqual(200, linkedList.First.Value);
        }

        [TestMethod]
        public void LinkedList_AddBefore_LastElement()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddLast(200);
            linkedList.AddBefore(200, 300);

            Assert.AreEqual(3, linkedList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(LinkedListNodeNotFoundException))]
        public void LinkedList_AddBefore_ThrowsExceptionWhenSearchNodeIsNotFound()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddLast(200);
            linkedList.AddBefore(400, 300);
        }
    }
}