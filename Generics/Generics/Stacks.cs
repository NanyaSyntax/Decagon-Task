using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Stacks<T>
    {

        private readonly SinglyLinkedList<T> singlyLinkedList;

        public Stacks()
        {
            singlyLinkedList = new SinglyLinkedList<T>();
        }

        public bool IsEmpty()
        {
            return singlyLinkedList.Size == 0;
        }

        public void push(T item)
        {
            
            singlyLinkedList.Add(item);
        }

        public void push(T item, int x)
        {

            singlyLinkedList.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            T item = singlyLinkedList.tail.Data;
            singlyLinkedList.Remove(item);
            return item;

        }
        public T Peek()
        {
            if (IsEmpty())
               throw new InvalidOperationException("Stack is empty");

           return singlyLinkedList.tail.Data;
        }

        public int Size()
        {
            return singlyLinkedList.Size;
        }
    }
}

