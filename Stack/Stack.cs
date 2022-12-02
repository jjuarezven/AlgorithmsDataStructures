using Common;

namespace Stack
{
    internal class StackImplementation<T>
    {
        private Node<T>? head;
        private Node<T>? current;
        public int Count { get; private set; }

        public StackImplementation()
        {
            head = new Node<T>();
        }

        // Push is adding a node in the beginning of the collection
        public void Push(T value)
        {
            var newNode = new Node<T>
            {
                Data = value,
                // preserve the reference to the current "next" of the head
                Next = head.Next,
            };
            head.Next = newNode;
            Count++;
        }

        public T Pop()
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
                current = head.Next;
                result = current.Data;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
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

        public bool IsEmpty() => head.Next == null;
    }
}
