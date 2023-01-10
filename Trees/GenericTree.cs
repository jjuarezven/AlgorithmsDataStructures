using Common;

namespace Trees
{
    internal class GenericTree
    {
        private TreeNode root;
        private TreeNode current;
        private int i = 0;

        public GenericTree()
        {
            root = new TreeNode();
        }

        public TreeNode Insert(string data, TreeNode? nodeToInsertIn)
        {
            TreeNode result;
            // if nodeToInsertIn = null, we take the root node to insert in
            if (nodeToInsertIn is null)
            {
                root.Data = data;
                result = root;
            }
            else
            {
                if (nodeToInsertIn.FirstChild is null)
                {
                    var newNode = new TreeNode(data);
                    nodeToInsertIn.FirstChild = newNode;
                    result = newNode;
                }
                else
                {
                    // if nodeToInsertIn has children, new node has to be inserted as sibling 
                    current = nodeToInsertIn.FirstChild;

                    while (current.NextSibling is not null)
                    {
                        current = current.NextSibling;
                    }

                    var newNode = new TreeNode(data);
                    current.NextSibling = newNode;
                    result = newNode;
                }
            }

            return result;
        }

        public TreeNode Search(string data, TreeNode? searchNode)
        {
            TreeNode? result = null;

            if (searchNode is null)
            {
                return result;
            }

            if (searchNode.Data.Equals(data))
            {
                result = searchNode;
                return result;
            }

            if (searchNode.FirstChild is not null)
            {
                result = Search(data, searchNode.FirstChild);
                if (result is not null)
                {
                    return result;
                }
            }

            if (searchNode.NextSibling is not null)
            {
                result = Search(data, searchNode.NextSibling);
                if (result is not null)
                {
                    return result;
                }
            }

            return result;
        }

        /// <summary>
        /// Preorder first process the node and later its children/siblings
        /// </summary>
        /// <param name="node"></param>
        public void TraversePreOrder(TreeNode node)
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

            if (node.FirstChild is not null)
            {
                i++;
                TraversePreOrder(node.FirstChild);
                i--;
            }

            if (node.NextSibling is not null)
            {
                TraversePreOrder(node.NextSibling);
            }
        }

        /// <summary>
        /// Postorder first process its children/siblings and later the node itself
        /// </summary>
        /// <param name="node"></param>
        public void TraversePostOrder(TreeNode node)
        {
            if (node is null)
            {
                return;
            }

            if (node.FirstChild is not null)
            {
                i++;
                TraversePostOrder(node.FirstChild);
                i--;
            }

            if (node.NextSibling is not null)
            {
                TraversePostOrder(node.NextSibling);
            }

            // this for is to add identation
            for (int n = 0; n < i; n++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(node.Data);
        }
    }
}
