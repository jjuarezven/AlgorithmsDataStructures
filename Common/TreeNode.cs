namespace Common
{
    public class TreeNode
    {
        public string? Data { get; set; }
        public TreeNode? FirstChild { get; set; }
        public TreeNode? NextSibling { get; set; }
        

        public TreeNode()
        {

        }

        public TreeNode(string data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return $"[{Data}]";
        }
    }
}
