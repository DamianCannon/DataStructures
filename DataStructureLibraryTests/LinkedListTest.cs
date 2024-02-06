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

        [Test]
        public void WhenThirdItemAddedToLinkedListWeCanTraverseThroughThemInOrder()
        {
            var list = new LinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");

            var firstFound = list.Traverse((node) => node.Value == firstItem.Value);
            Assert.Multiple(() =>
            {
                Assert.That(list.Head, Is.EqualTo(firstFound));
                Assert.That(firstFound?.Next, Is.EqualTo(secondItem));
            });

            var secondFound = list.Traverse((node) => node.Value == secondItem.Value);
            Assert.Multiple(() =>
            {
                Assert.That(list.Head?.Next, Is.EqualTo(secondFound));
                Assert.That(secondFound?.Next, Is.EqualTo(thirdItem));
            });

            var thirdFound = list.Traverse((node) => node.Value == thirdItem.Value);
            Assert.Multiple(() =>
            {
                Assert.That(list.Head?.Next?.Next, Is.EqualTo(thirdFound));
                Assert.That(thirdFound?.Next, Is.Null);
            });
        }

        [Test]
        public void WhenTraverseFunctionIsAlwaysFalseThenLastNodeIsFound()
        {
            var list = new LinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");

            var foundItem = list.Traverse((node) => false);
            Assert.Multiple(() =>
            {
                Assert.That(foundItem, Is.EqualTo(thirdItem));
                Assert.That(foundItem?.Next, Is.Null);
            });
        }

    }
}