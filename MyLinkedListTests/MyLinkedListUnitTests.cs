using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinkedListTests
{
    [TestClass]
    public class MyLinkedListUnitTests
    {
        [TestMethod]
        public void DoesAddAtHeadAddNode()
        {
            var myLinkedList = new MyLinkedList.MyLinkedList();

            myLinkedList.AddAtHead(5);

            Assert.AreEqual(myLinkedList.head.data, 5);

            myLinkedList.AddAtHead(7);

            Assert.AreEqual(myLinkedList.head.data, 7);

            Assert.IsNotNull(myLinkedList.head.next);

            Assert.AreEqual(myLinkedList.head.next.data, 5);
        }
    }
}
