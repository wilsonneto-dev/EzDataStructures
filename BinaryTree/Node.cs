namespace EzDataStructures.BinaryTree;

public class Node<T>
{
    public T Value { get; set; }
    public Node<T>? Left { get; set; }
    public Node<T>? Right { get; set; }

    public Node(T value, Node<T>? left = null, Node<T>? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}
