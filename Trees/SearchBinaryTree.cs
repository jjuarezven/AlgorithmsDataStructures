using Common;

namespace Trees
{
    internal class SearchBinaryTree<T> where T : IComparable<T>
    {
        public BinaryTreeNode<T>? Root { get; set; }
        private BinaryTreeNode<T>? current;
        private int i = 0;

        public SearchBinaryTree()
        {
            Root = null;
            current = null;
        }

        public BinaryTreeNode<T> Insert(T data, BinaryTreeNode<T> node)
        {
            if (node is null)
            {
                return new BinaryTreeNode<T>(data);
            }

            if (data.CompareTo(node.Data) < 0)
            {
                node.Left = Insert(data, node.Left);
            }

            if (data.CompareTo(node.Data) > 0)
            {
                node.Right = Insert(data, node.Right);
            }

            return node;
        }

        public void TraversePreOrder(BinaryTreeNode<T> node)
        {
            if (node is null)
            {
                return;
            }

            // this for is to add identation
            for (int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(node.Data);

            if (node.Left is not null)
            {
                i++;
                Console.Write("L ");
                TraversePreOrder(node.Left);
                i--;
            }

            if (node.Right is not null)
            {
                i++;
                Console.Write("R ");
                TraversePreOrder(node.Right);
                i--;
            }
        }
    }
}
