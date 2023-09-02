using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Queue<T>
    {
        private readonly SinglyLinkedList<T> singlyLinkedList;

        public Queue()
        {
            singlyLinkedList = new SinglyLinkedList<T>();
        }

        public bool IsEmpty()
        {
            return singlyLinkedList.Size == 0;
        }

        public void Enqueue(T item)
        {
            singlyLinkedList.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())

                throw new InvalidOperationException("Stack is empty");

            T item = singlyLinkedList.head.Data;
            singlyLinkedList.Remove(item);
            return item;

        }

        public int Size()
        {
            return singlyLinkedList.Size;
        }
    }
}
