namespace DataStructureLibrary
{
    public class LinkedListNode
    {
        private readonly string? _value;
        private LinkedListNode? _next;

        public LinkedListNode(string value)
        {
            _value = value;
            _next = null;
        }

        public string? Value {
            get
            {
                return _value;
            }
        }

        public LinkedListNode? Next
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
    }
}
