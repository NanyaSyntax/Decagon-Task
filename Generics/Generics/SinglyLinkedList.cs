using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   
    public class SinglyLinkedList<T>
    {
       
        public class Node
        {
            
            public T Data;
            public Node Nest;

            public Node(T data)
            {
                this.Data = data;
            }
        }
        
        public Node head = default;
        public Node tail = default;
        private int size;

        public int Size { get { return size; } }

      
        public int Add(T item)
        {
            Node newNode = new Node(item);

            if (head == null)
            {
               
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Nest = newNode;
                tail = newNode;
            }
            size++; 
            return size;
        }

        public bool Remove(T item)
        {
            //
            Node currentNode = head;
            Node previousNode = null;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(item)) 
                {
                    if (previousNode == null)
                    {
                        head = currentNode.Nest;
                        if (head == null)
                            tail = null;
                    }
                    else
                    {
                        previousNode.Nest = currentNode.Nest;
                        if (currentNode.Nest == null)
                            tail = previousNode;
                    }
                    size--;
                    return true;
                }
                previousNode = currentNode; 
                currentNode = currentNode.Nest;
            }
            return false;
        }
        public bool CheckForItem(T item)
        {
           Node currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(item))

                    return true;
                currentNode = currentNode.Nest;
            }
            return false;
        }
        public int Index(T item)
        {
            Node currentNode = head;
            int indexx = 0;

            while (currentNode != null)
            {
                if (currentNode.Data.Equals(item))

                        return indexx;
                currentNode = currentNode.Nest;
                indexx++;

            }
            return -1;
        }
    }
}
