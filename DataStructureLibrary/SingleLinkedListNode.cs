namespace DataStructureLibrary
{
    public class SingleLinkedListNode
    {
        private readonly string? _value;
        private SingleLinkedListNode? _next;

        public SingleLinkedListNode(string value)
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

        public SingleLinkedListNode? Next
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
