namespace EzDataStructures.BinaryTree;

public class Tree<T>
{
    public Node<T>? Root { get; set; }	

    public Tree(Node<T>? root)
        => Root = root;
}