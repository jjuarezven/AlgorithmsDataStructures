namespace Common
{
    public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
    {
        public T? Data { get; set; }
        public BinaryTreeNode<T>? Left { get; set; }
        public BinaryTreeNode<T>? Right { get; set; }

        public BinaryTreeNode(T data)
        {
            Data = data;
        }

        public int CompareTo(BinaryTreeNode<T> other)
        {
            return Data.CompareTo(other.Data);
        }

        public override string ToString()
        {
            return $"[{Data}]";
        }
    }
}
