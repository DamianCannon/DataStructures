namespace DataStructureLibrary
{
    public class LinkedList
    {
        private LinkedListNode? _head;

        public LinkedList()
        {
            _head = null;
        }

        public LinkedListNode? Head
        {
            get
            {
                return _head;
            }
        }

        public LinkedListNode Append(string value)
        {
            var newNode = new LinkedListNode(value);
            if (_head == null)
            {
                _head = newNode;
            } 
            else
            {
                var currentNode = _head;
                while (currentNode.Next !=  null)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = newNode;
            }

            return newNode;
        }

        public LinkedListNode? Traverse(Func<LinkedListNode, bool> IsNodeAMatch)
        {
            var currentNode = _head;
            LinkedListNode? lastNode = null;
            while (currentNode != null)
            {
                if (IsNodeAMatch(currentNode))
                {
                    return currentNode;
                }

                lastNode = currentNode;
                currentNode = currentNode.Next;
            }

            return lastNode;
        }

        // Core operations
        // Insert
        // Delete
        // Search

    }
}
