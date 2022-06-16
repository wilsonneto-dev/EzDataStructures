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
        var nodes = input.Replace("[","").Replace("]","").Split(',').Select(x => x.Trim());
        var queue = new Queue<T?>();
        foreach(var nodeValueInString in nodes)
        {
            var extractedNode = nodeValueInString == emptyEquivalent ? null : valueExtractor?.Invoke(nodeValueInString);
            queue.Enqueue(extractedNode);
        }
        var root = new Node<T>(default!);
        var queue = new Queue<Node<T>>();
        return null;
    }
}