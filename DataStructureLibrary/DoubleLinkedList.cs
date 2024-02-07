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
    public class DoubleLinkedList
    {
        private DoubleLinkedListNode? _head;

        public DoubleLinkedList()
        {
            _head = null;
        }

        public DoubleLinkedListNode? Head
        {
            get
            {
                return _head;
            }
        }

        public DoubleLinkedListNode Append(string value)
        {
            var newNode = new DoubleLinkedListNode(value);
            if (_head == null)
            {
                _head = newNode;
            } 
            else
            {
                var lastNode = Traverse((node) => false);
                if (lastNode != null)
                {
                    lastNode.Next = newNode;
                    newNode.Prev = lastNode;
                }
            }

            return newNode;
        }

        public DoubleLinkedListNode? Traverse(Func<DoubleLinkedListNode, bool> IsNodeAMatch)
        {
            var currentNode = _head;
            DoubleLinkedListNode? lastNode = null;
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

        public DoubleLinkedListNode InsertAt(DoubleLinkedListNode node, string value) {
            var newNode = new DoubleLinkedListNode(value)
            {
                Next = node.Next,
                Prev = node
            };
            node.Next = newNode;
            if (newNode.Next != null)
            {
                newNode.Next.Prev = newNode;
            }
            return newNode;
        }

        public void Remove(DoubleLinkedListNode node)
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
