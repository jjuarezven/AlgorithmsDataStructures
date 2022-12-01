namespace Common
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T>? Next { get; set; }

        public override string ToString()
        {
            if (Data == null)
                return string.Empty;
            return $"{Data}";
        }
    }
}
