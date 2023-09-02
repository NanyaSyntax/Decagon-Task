namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList<int> singlyLinkedList = new SinglyLinkedList<int>();

            singlyLinkedList.Add(1);
            singlyLinkedList.Add(2);
            singlyLinkedList.Add(3);
            singlyLinkedList.Add(4);
            singlyLinkedList.Add(5);

            Console.WriteLine();
            Console.WriteLine("Linked List");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("List size: " + singlyLinkedList.Add(6));
            Console.WriteLine("List size: " + singlyLinkedList.Add(7));
            Console.WriteLine();

            Console.WriteLine("Removed: " + singlyLinkedList.Remove(6));
            Console.WriteLine("Removed: " + singlyLinkedList.Remove(6));
            Console.WriteLine();

            Console.WriteLine("Check: " + singlyLinkedList.CheckForItem(2));
            Console.WriteLine("Check: " + singlyLinkedList.CheckForItem(12));
            Console.WriteLine();

            Console.WriteLine("Index: " + singlyLinkedList.Index(2));
            Console.WriteLine("Index: " + singlyLinkedList.Index(20));


            Stacks<int> stacks = new Stacks<int>();
            Console.WriteLine();
            Console.WriteLine("STACK");
            Console.WriteLine();
            Console.WriteLine("Stack is empty = " + stacks.IsEmpty());
            Console.WriteLine();

            stacks.push(25);
            stacks.push(26);
            stacks.push(27);
            stacks.push(28);
            stacks.push(29);

            Console.WriteLine("Stack is empty = " + stacks.IsEmpty());
            Console.WriteLine();
            Console.WriteLine("Stack size = " + stacks.Size());
            Console.WriteLine();
            Console.WriteLine("Last item added to stack is = " + stacks.Peek());
            Console.WriteLine();
            Console.WriteLine("Last item removed from stack is = " + stacks.Pop());
            Console.WriteLine();
            Console.WriteLine("Last item added to stack is = " + stacks.Peek());
            Console.WriteLine();

            Queue<int> queue = new Queue<int>();
            Console.WriteLine();
            Console.WriteLine("QUEUE");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Queue is empty = " + queue.IsEmpty());
            Console.WriteLine();

            queue.Enqueue(45);
            queue.Enqueue(46);
            queue.Enqueue(47);
            queue.Enqueue(48);
            queue.Enqueue(49);
            queue.Enqueue(50);

            Console.WriteLine("Queue is empty = " + queue.IsEmpty());
            Console.WriteLine();
            Console.WriteLine("Queue size = " + queue.Size());
            Console.WriteLine();
            Console.WriteLine("Removed first item added which is = " + queue.Dequeue());
            Console.WriteLine();
            Console.WriteLine("Queue size = " + queue.Size());



        }
    }
}