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

        // Core operations
        // Insert
        // Delete
        // Traverse
        // Search

    }
}
