using DataStructureLibrary;

namespace DataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single linked list test");
            var singleLinkedList = new SingleLinkedList();
            var printSingleList = () => singleLinkedList.Traverse((node) =>
            {
                Console.WriteLine(node.Value);
                return false;
            });

            var firstNode = singleLinkedList.Append("Test Case 1");
            var secondNode = singleLinkedList.Append("Test Case 2");
            var thirdNode = singleLinkedList.Append("Test Case 3");
            printSingleList();
            Console.WriteLine("Inserting at position 2");
            singleLinkedList.InsertAt(secondNode, "Test Case 4");
            printSingleList();
            Console.WriteLine("Removing at position 2");
            singleLinkedList.Remove(secondNode);
            printSingleList();

            Console.WriteLine(new string('-', 64));
            Console.WriteLine("Double linked list test");
            var doubleLinkedList = new DoubleLinkedList();
            var printDoubleList = () => doubleLinkedList.Traverse((node) =>
            {
                Console.WriteLine(node.Value);
                return false;
            });

            var firstNode2 = doubleLinkedList.Append("Test Case 1");
            var secondNode2 = doubleLinkedList.Append("Test Case 2");
            var thirdNode2 = doubleLinkedList.Append("Test Case 3");
            printDoubleList();
            Console.WriteLine("Inserting at position 2");
            doubleLinkedList.InsertAt(secondNode2, "Test Case 4");
            printDoubleList();
            Console.WriteLine("Removing at position 2");
            doubleLinkedList.Remove(secondNode2);
            printDoubleList();

            Console.ReadKey();
        }
    }
}
