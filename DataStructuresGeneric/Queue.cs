using System;

namespace GenericDataStructures
{
    public class Queue<T>
    {
        SinglyLinkedList<T> queueList = new SinglyLinkedList<T>();

        public bool IsEmpty()
        {
            if(queueList.head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Enqueue(T item)
        {
           queueList.Add(item);
        }

        public T Dequeue()
        {
            if(queueList.head == null)
            {
                return default(T);
            }
            else
            {
                var itemToDequeue = queueList.head.Item;
                queueList.head = queueList.head.Next;
                return itemToDequeue;
            }
        }

        public int Size()
        {
            return queueList.count;
        }

        public void Print()
        {
            Node<T> currentNode = queueList.head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Item);
                currentNode = currentNode.Next;
            }
        }
    }
}