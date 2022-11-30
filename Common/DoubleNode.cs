namespace Common
{
    public class DoubleNode
    {
        public int? Data { get; set; }
        public DoubleNode? Next { get; set; }
        public DoubleNode? Previous { get; set; }

        public override string ToString()
        {
            return $"[{Data}]";
        }
    }
}
