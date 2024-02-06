using DataStructureLibrary;

namespace DataStructureLibraryTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenLinkedListCreatedItHasNoNodes()
        {
            var list = new LinkedList();
            Assert.That(list.Head, Is.Null);
        }

        [Test]
        public void WhenFirstItemAddedToLinkedListItHasAHeadNode()
        {
            var list = new LinkedList();
            list.Append("Test Case");
            Assert.That(list.Head, Is.Not.Null);
        }
    }
}