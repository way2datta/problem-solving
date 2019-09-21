using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSolving.Tests
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
        }

        [TestMethod]
        public void LinkedList_AddFirst_WhenListIsNotEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddFirst(100);
            linkedList.AddFirst(200);

            Assert.AreEqual(2, linkedList.Count);
        }

        [TestMethod]
        public void LinkedList_AddLast_WhenListIsEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);

            Assert.AreEqual(1, linkedList.Count);
        }

        [TestMethod]
        public void LinkedList_AddLast_WhenListIsNotEmpty()
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.AddLast(100);
            linkedList.AddLast(200);

            Assert.AreEqual(2, linkedList.Count);
        }
    }
}
