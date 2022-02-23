namespace GenericDataStructures
{
    public class Node<T>
    {
       public Node<T> Next;
        public T Item;

        public Node(T item)
    {
        Next = null;
        Item = item;

    }


}

    
}
