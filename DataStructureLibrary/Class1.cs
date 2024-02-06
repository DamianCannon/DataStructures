namespace DataStructureLibrary
{
    public class LinkedListNode
    {
        private string _value;
        private LinkedListNode? _next;

        public LinkedListNode(string value)
        {
            _value = value;
            _next = null;
        }

        public LinkedListNode AddNext(string value)
        {
            _next = new LinkedListNode(value);
            return _next;
        }

    }
}
