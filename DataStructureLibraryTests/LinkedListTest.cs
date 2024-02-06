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
    }
}