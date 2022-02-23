using System;

namespace GenericDataStructures
{
    public class SinglyLinkedList<T>
    {
        public Node<T> head;
        public int count;
        public SinglyLinkedList()
        {
            head = null;
            count = 0;
        }
        
        public int Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            if(head == null)
            {
                head = newNode;
                count++;
            }
            else
            {
                Node<T> temporaryHead = head;
                while(temporaryHead.Next != null)
                {
                    temporaryHead = temporaryHead.Next;
                }
                temporaryHead.Next = newNode;
                count++;
            }
            return count;
        }

        public bool Remove(T item)
        {
            if(head == null)
            {
                return false;
            }
            else if (head.Item.Equals(item))
            {
                head = head.Next;
                return true;
            }
            else
            {
                Node<T> previousNode = head;
                Node<T> currentNode = head.Next;
                
                while(currentNode != null)
                {
                    if (currentNode.Item.Equals(item))
                    {
                        previousNode.Next = currentNode.Next;
                        return true;
                    }
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }
                return false;

            }
        }

        public bool Check(T item)
        {
            if(head == null)
            {
                return false;
            }
            else if (head.Item.Equals(item))
            {
                return true;
            }
            else
            {
                Node<T> currentNode = head;
                while(currentNode.Next != null)
                {
                    if (currentNode.Item.Equals(item))
                    {
                        return true;
                    }
                    currentNode = currentNode.Next;
                }
                return false;
            }
        }

        public int Index(T item)
        {
            int index = 0;  
            if(head == null)
            {
                return -1;
            }
            else if (head.Item.Equals(item))
            {
                return index;
            }
            else 
            {
                Node<T> currentNode = head;
                while (currentNode.Next != null)
                {
                    if (currentNode.Item.Equals(item))
                    {
                        return index;
                    }
                    currentNode = currentNode.Next;
                    index++;
                }
                return -1;
            }
        }
        public void Print()
        {
            Node<T> currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Item);
                currentNode = currentNode.Next;
            }
        }
    }
}
