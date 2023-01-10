using Common;

namespace Queue
{
    internal class QueueImplementation<T>
    {
        private Node<T> head;
        private Node<T> current;
        public int Count { get; private set; }

        public QueueImplementation() => head = new Node<T>();

        public void Enqueue(T value)
        {
            var lastNode = FindLastNode();
            var newNode = new Node<T>(value);
            lastNode.Next = newNode;
            Count++;
        }

        public T Dequeue()
        {
            T result;
            if (head.Next is not null)
            {
                current = head.Next;
                result = current.Data;

                head.Next = current.Next;
                current.Next = null;
                Count--;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return result;
        }

        public T Peek()
        {
            T result;
            if (head.Next is not null)
            {
                result = head.Next.Data;
            }
            else
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return result;
        }

        public void Traverse()
        {
            current = head;
            while (current.Next is not null)
            {
                current = current.Next;
                Console.WriteLine($"{current.Data}");
            }
        }

        private Node<T> FindLastNode()
        {
            current = head;
            while (current.Next is not null)
            {
                current = current.Next;                
            }
            return current;
        }
    }
}
