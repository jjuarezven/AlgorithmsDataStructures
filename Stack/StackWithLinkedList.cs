using LinkedLists;

namespace Stack
{
    internal class StackWithLinkedList<T>
    {
        public int Count { get; private set; }
        private SingleLinkedList<T> list;

        public StackWithLinkedList()
        {
            list = new SingleLinkedList<T>();
        }

        // Push is adding a node in the beginning of the collection
        public void Push(T value)
        {
            list.AddAtStart(value);
            Count++;
        }

        public T Pop()
        {
            T result;
            if (list.Length > 0)
            {
                var node = list.FindNodeByIndex(0);
                result = node.Data;
                list.DeleteNodeByValue(result);
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
            if (list.Length > 0)
            {
                var node = list.FindNodeByIndex(0);
                result = node.Data;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return result;
        }

        public void Traverse()
        {
            list.Traverse();
        }
    }
}
