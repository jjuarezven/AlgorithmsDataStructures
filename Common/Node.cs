namespace Common
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }

        public override string ToString()
        {
            return $"[{Data}]";
        }
    }
}
