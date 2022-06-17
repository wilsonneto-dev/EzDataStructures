using EzDataStructures.BinaryTree;

namespace EzDataStructures.Helpers.Extensions;

public static class StringToBinaryTreeExtension
{
    public static Tree<T> ToBinaryTree<T>(
        this string input,
        Func<string, T?>? valueExtractor = null,
        string emptyEquivalent = "-1"
    )
        where T : class
    {
        if(valueExtractor == null && typeof(T) == typeof(int))
            valueExtractor = stringValue => int.Parse(stringValue) as T;
        var nodes = input.Replace("[","").Replace("]","").Split(',').Select(x => x.Trim()).ToList();
        var totalItems = nodes.Count;
        if(totalItems == 0)
            throw new InvalidCastException("The sequence should have at leat one item");

        var queue = new Queue<T?>();
        foreach(var nodeValueInString in nodes)
        {
            var extractedNode = nodeValueInString == emptyEquivalent ? null : valueExtractor?.Invoke(nodeValueInString);
            queue.Enqueue(extractedNode);
        }
        var root = queue.Dequeue();
        if(root is null)
            throw new InvalidCastException("The tree root node shouldn't be null");

        new Tree<T>(new Node<T>(root));
        
        return null;
    }
}