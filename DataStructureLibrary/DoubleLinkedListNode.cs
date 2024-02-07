namespace DataStructureLibrary
{
    public class DoubleLinkedListNode
    {
        private readonly string? _value;
        private DoubleLinkedListNode? _prev;
        private DoubleLinkedListNode? _next;

        public DoubleLinkedListNode(string value)
        {
            _value = value;
            _prev = null;
            _next = null;
        }

        public string? Value {
            get
            {
                return _value;
            }
        }

        public DoubleLinkedListNode? Next
        {
            get
            {
                return _next;
            }
            set 
            {
                _next = value;
            }
        }

        public DoubleLinkedListNode? Prev
        {
            get
            {
                return _prev;
            }
            set 
            {
                _prev = value;
            }
        }
    }
}
