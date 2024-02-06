using DataStructureLibrary;

namespace DataStructureLibraryTests
{
    public class Tests
    {
        [Test]
        public void WhenLinkedListCreatedItHasNoNodes()
        {
            var list = new SingleLinkedList();
            Assert.That(list.Head, Is.Null);
        }

        [Test]
        public void WhenFirstItemAddedToLinkedListItHasAHeadNodeButNoFollowingNode()
        {
            var list = new SingleLinkedList();
            list.Append("Test Case 1");
            Assert.That(list.Head, Is.Not.Null);
            Assert.That(list.Head.Next, Is.Null);
        }

        [Test]
        public void WhenSecondItemAddedToLinkedListItHasAHeadNodeAndAFollowingNode()
        {
            var list = new SingleLinkedList();
            list.Append("Test Case 1");
            list.Append("Test Case 2");
            Assert.That(list.Head, Is.Not.Null);
            Assert.That(list.Head.Next, Is.Not.Null);
        }

        [Test]
        public void WhenThirdItemAddedToLinkedListWeCanTraverseThroughThemInOrder()
        {
            var list = new SingleLinkedList();
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
            var list = new SingleLinkedList();
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

        [Test]
        public void WhenListHasOneNodeAnotherOneCanBeInsertedAtTheEnd()
        {
            var list = new SingleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.InsertAt(firstItem, "Test Case 2");

            Assert.Multiple(() =>
            {
                Assert.That(list.Head, Is.EqualTo(firstItem));
                Assert.That(list.Head?.Next, Is.EqualTo(secondItem));
            });
        }

        [Test]
        public void WhenListHasTwoNodesAnotherOneCanBeInsertedBetweenThem()
        {
            var list = new SingleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.InsertAt(firstItem, "Test Case 3");

            Assert.Multiple(() =>
            {
                Assert.That(list.Head, Is.EqualTo(firstItem));
                Assert.That(list.Head?.Next, Is.EqualTo(thirdItem));
                Assert.That(list.Head?.Next?.Next, Is.EqualTo(secondItem));
            });
        }

        [Test]
        public void WhenListHasOneNodeItCanBeRemoved()
        {
            var list = new SingleLinkedList();
            var firstItem = list.Append("Test Case 1");
            list.Remove(firstItem);

            Assert.That(list.Head, Is.Null);
        }
        
        [Test]
        public void WhenListHasTwoNodesTheFirstCanBeRemoved()
        {
            var list = new SingleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            list.Remove(firstItem);

            Assert.That(list.Head, Is.EqualTo(secondItem));
            Assert.That(list.Head?.Next, Is.Null);
        }

        [Test]
        public void WhenListHasThreeNodesTheSecondCanBeRemoved()
        {
            var list = new SingleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");
            list.Remove(secondItem);

            Assert.That(list.Head, Is.EqualTo(firstItem));
            Assert.That(list.Head?.Next, Is.EqualTo(thirdItem));
            Assert.That(list.Head?.Next?.Next, Is.Null);
        }

        [Test]
        public void WhenListHasThreeNodesTheLastCanBeRemoved()
        {
            var list = new SingleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");
            list.Remove(thirdItem);

            Assert.That(list.Head, Is.EqualTo(firstItem));
            Assert.That(list.Head?.Next, Is.EqualTo(secondItem));
            Assert.That(list.Head?.Next?.Next, Is.Null);
        }
    }
}