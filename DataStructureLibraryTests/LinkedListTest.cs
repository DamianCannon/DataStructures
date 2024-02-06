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
        public void WhenFirstItemAddedToLinkedListItHasAHeadNodeButNoFollowingNode()
        {
            var list = new LinkedList();
            list.Append("Test Case 1");
            Assert.That(list.Head, Is.Not.Null);
            Assert.That(list.Head.Next, Is.Null);
        }

        [Test]
        public void WhenSecondItemAddedToLinkedListItHasAHeadNodeAndAFollowingNode()
        {
            var list = new LinkedList();
            list.Append("Test Case 1");
            list.Append("Test Case 2");
            Assert.That(list.Head, Is.Not.Null);
            Assert.That(list.Head.Next, Is.Not.Null);
        }

    }
}