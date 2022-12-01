using LinkedLists;

namespace Stack
{
    internal class StackWithLinkedList
    {
        public int Count { get; private set; }
        private SingleLinkedList list;

        public StackWithLinkedList()
        {
            list = new SingleLinkedList();
        }

        // Push is adding a node in the beginning of the collection
        public void Push(int value)
        {
            list.AddAtStart(value);
            Count++;
        }

        public int Pop()
        {
            int result;
            if (list.Length > 0)
            {
                var node = list.FindNodeByIndex(1);
                result = node.Data;
                list.Delete(1);
                Count--;
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return result;
        }

        public int Peek()
        {
            int result;
            if (list.Length > 0)
            {
                var node = list.FindNodeByIndex(1);
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
