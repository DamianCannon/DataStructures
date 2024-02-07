using DataStructureLibrary;

namespace DataStructureLibraryTests
{
    public class DoubleLinkedListTests
    {
        [Test]
        public void WhenLinkedListCreatedItHasNoNodes()
        {
            var list = new DoubleLinkedList();
            Assert.That(list.Head, Is.Null);
        }

        [Test]
        public void WhenFirstItemAddedToLinkedListItHasAHeadNodeButNoFollowingNode()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            Assert.That(list.Head, Is.EqualTo(firstItem));
            Assert.That(list.Head.Next, Is.Null);
            Assert.That(list.Head.Prev, Is.Null);
        }

        [Test]
        public void WhenSecondItemAddedToLinkedListItHasAHeadNodeAndAFollowingNode()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            Assert.That(list.Head, Is.EqualTo(firstItem));
            Assert.That(list.Head.Next, Is.EqualTo(secondItem));
            Assert.That(list.Head.Next.Prev, Is.EqualTo(firstItem));
        }

        [Test]
        public void WhenThirdItemAddedToLinkedListWeCanTraverseThroughThemInOrder()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");

            var firstFound = list.Traverse((node) => node.Value == firstItem.Value);
            Assert.Multiple(() =>
            {
                Assert.That(list.Head, Is.EqualTo(firstFound));
                Assert.That(firstFound?.Next, Is.EqualTo(secondItem));
                Assert.That(firstFound?.Prev, Is.Null);
            });

            var secondFound = list.Traverse((node) => node.Value == secondItem.Value);
            Assert.Multiple(() =>
            {
                Assert.That(list.Head?.Next, Is.EqualTo(secondFound));
                Assert.That(secondFound?.Next, Is.EqualTo(thirdItem));
                Assert.That(secondFound?.Prev, Is.EqualTo(firstItem));
            });

            var thirdFound = list.Traverse((node) => node.Value == thirdItem.Value);
            Assert.Multiple(() =>
            {
                Assert.That(list.Head?.Next?.Next, Is.EqualTo(thirdFound));
                Assert.That(thirdFound?.Next, Is.Null);
                Assert.That(thirdFound?.Prev, Is.EqualTo(secondItem));
            });
        }

        [Test]
        public void WhenTraverseFunctionIsAlwaysFalseThenLastNodeIsFound()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");

            var foundItem = list.Traverse((node) => false);
            Assert.Multiple(() =>
            {
                Assert.That(foundItem, Is.EqualTo(thirdItem));
                Assert.That(foundItem?.Next, Is.Null);
                Assert.That(foundItem?.Prev, Is.EqualTo(secondItem));
            });
        }

        [Test]
        public void WhenListHasOneNodeAnotherOneCanBeInsertedAtTheEnd()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.InsertAt(firstItem, "Test Case 2");

            Assert.Multiple(() =>
            {
                Assert.That(list.Head, Is.EqualTo(firstItem));
                Assert.That(list.Head?.Next, Is.EqualTo(secondItem));
                Assert.That(list.Head?.Next?.Prev, Is.EqualTo(firstItem));
            });
        }

        [Test]
        public void WhenListHasTwoNodesAnotherOneCanBeInsertedBetweenThem()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.InsertAt(firstItem, "Test Case 3");

            Assert.Multiple(() =>
            {
                Assert.That(list.Head, Is.EqualTo(firstItem));
                Assert.That(list.Head?.Next, Is.EqualTo(thirdItem));
                Assert.That(list.Head?.Next?.Prev, Is.EqualTo(firstItem));
                Assert.That(list.Head?.Next?.Next, Is.EqualTo(secondItem));
                Assert.That(list.Head?.Next?.Next?.Prev, Is.EqualTo(thirdItem));
            });
        }

        [Test]
        public void WhenListHasOneNodeItCanBeRemoved()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            list.Remove(firstItem);

            Assert.That(list.Head, Is.Null);
        }
        
        [Test]
        public void WhenListHasTwoNodesTheFirstCanBeRemoved()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            list.Remove(firstItem);

            Assert.That(list.Head, Is.EqualTo(secondItem));
            Assert.That(list.Head?.Next, Is.Null);
            Assert.That(list.Head?.Prev, Is.Null);
        }

        [Test]
        public void WhenListHasThreeNodesTheSecondCanBeRemoved()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");
            list.Remove(secondItem);

            Assert.That(list.Head, Is.EqualTo(firstItem));
            Assert.That(list.Head?.Next, Is.EqualTo(thirdItem));
            Assert.That(list.Head?.Next?.Next, Is.Null);
            Assert.That(list.Head?.Next?.Prev, Is.EqualTo(firstItem));
        }

        [Test]
        public void WhenListHasThreeNodesTheLastCanBeRemoved()
        {
            var list = new DoubleLinkedList();
            var firstItem = list.Append("Test Case 1");
            var secondItem = list.Append("Test Case 2");
            var thirdItem = list.Append("Test Case 3");
            list.Remove(thirdItem);

            Assert.That(list.Head, Is.EqualTo(firstItem));
            Assert.That(list.Head?.Next, Is.EqualTo(secondItem));
            Assert.That(list.Head?.Next?.Next, Is.Null);
            Assert.That(list.Head?.Next?.Prev, Is.EqualTo(firstItem));
        }
    }
}