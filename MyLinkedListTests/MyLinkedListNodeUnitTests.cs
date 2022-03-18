using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyLinkedListTests
{
    [TestClass]
    public class MyLinkedListNodeUnitTests
    {
        [TestMethod]
        public void IsDataFieldSetCorrectly()
        {
            var MyLinkedListNode = new MyLinkedList.MyLinkedListNode(5);
            Assert.AreEqual(MyLinkedListNode.data, 5);
        }
    }
}
