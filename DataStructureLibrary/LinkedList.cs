namespace DataStructureLibrary
{
    // Values stored in non-contiguous memory locations
    // List can grow or shrink in size
    // Based on node instances and pointers between them
    // Comes in two types:
    // 1. Singly Linked List
    // 2. Doubly Linked List
    //
    // Operations:
    // 1. Append
    // 2. Traverse
    // 3. InsertAt
    // 4. Remove
    // 5. Find
    //
    // Negatives:
    // 1. No random access
    // 2. Extra memory space for pointers
    // 3. Retrieval is always O(n)
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

        public LinkedListNode InsertAt(LinkedListNode node, string value) {
            var newNode = new LinkedListNode(value)
            {
                Next = node.Next
            };
            node.Next = newNode;
            return newNode;
        }

        public void Remove(LinkedListNode node)
        {
            if (_head == node)
            {
                _head = node?.Next;
            }
            else 
            { 
                var previousNode = Traverse((currentNode) => currentNode.Next == node);
                if (previousNode != null)
                {
                    previousNode.Next = node?.Next;
                }
            }
        }
    }
}
