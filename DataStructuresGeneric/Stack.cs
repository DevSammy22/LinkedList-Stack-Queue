using System;

namespace GenericDataStructures
{
    public class Stack<T>
    {
        SinglyLinkedList<T> stackList = new SinglyLinkedList<T>();

        public bool IsEmpty()
        {
            if(stackList.head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Push(T item)
        {
            stackList.Add(item);
        }

        public T Pop()
        {
            if(stackList.head == null)
            {
                return default(T);
            }
            else
            {
                Node<T> previousNode = stackList.head;
                Node<T> currentNode = stackList.head.Next;
                
                while(currentNode.Next != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
                T lastItem = currentNode.Item;
                previousNode.Next = null;
                return lastItem;
            }
        }

        public T Peek()
        {
            if(stackList.head == null)
            {
                return default(T);
            }
            else
            {
                Node<T> currentNode = stackList.head;
                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Item;
            }
        }

        public int Size()
        {
            return stackList.count;
        }

        public void Print()
        {
            Node<T> currentNode = stackList.head;
            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Item);
                currentNode = currentNode.Next;
            }
        }
    }
}
