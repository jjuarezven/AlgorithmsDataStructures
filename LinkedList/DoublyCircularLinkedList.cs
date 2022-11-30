using Common;

namespace LinkedLists
{
    internal class DoublyCircularLinkedList
    {
        private DoubleNode? head;
        private DoubleNode? tail;
        public int Length { get; private set; }

        public void AddAtStart(int nodeData)
        {
            var newNode = new DoubleNode
            {
                Data = nodeData
            };

            if (head is null)
            {
                SetHeader(newNode);
            }
            else
            {
                SetNodeAsHeader(newNode);
            }

            Length++;
        }

        public void AddAtEnd(int nodeData)
        {
            var newNode = new DoubleNode
            {
                Data = nodeData
            };

            if (head is null)
            {
                SetHeader(newNode);
            }
            else
            {
                newNode.Previous = tail;
                newNode.Next = head;
                tail.Next = newNode;
                head.Previous = newNode;
                tail = newNode;
            }
            Length++;
        }

        public void AddAtPosition(int nodeData, int position)
        {
            if (position > Length || position < 1)
            {
                Console.WriteLine($"Position should be greater or equal to 1 AND less than or equal to {Length} ");
                return;
            }

            var newNode = new DoubleNode
            {
                Data = nodeData
            };

            if (position == 1)
            {
                SetNodeAsHeader(newNode);
            }
            else
            {
                //make a nodeToReplace node and traverse to the node previous to the position
                var nodeToReplace = head;
                while (nodeToReplace is not null && position > 1)
                {
                    nodeToReplace = nodeToReplace.Next;
                    position--;
                }

                // we need the reference to the previous node of the node that will be replaced
                var previousNodeToNodeToReplace = nodeToReplace.Previous;
                previousNodeToNodeToReplace.Next = newNode;

                newNode.Previous = previousNodeToNodeToReplace;
                newNode.Next = nodeToReplace;
                nodeToReplace.Previous = newNode;
            }

            Length++;
        }

        public void Traverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                var node = head;
                for (int i = 0; i < Length; i++)
                {
                    Console.WriteLine($"{node.Data}");
                    node = node.Next;
                }
            }
        }

        public void Clear()
        {
            var current = head.Next;
            DoubleNode temp = null;
            while (current is not null && current != head)
            {
                temp = current.Next;
                current = null;
                current = temp;
            }

            head = null;
            Length = 0;
        }

        public bool DeleteNodeByValue(int nodeData)
        {
            if (!IsEmpty())
            {
                var nodeToRemove = FindNodeByValue(nodeData);
                var previous = nodeToRemove.Previous;
                previous.Next = nodeToRemove.Next;
                nodeToRemove.Next.Previous = nodeToRemove.Previous;

                // if this is head, we need to update the head reference
                if (head == nodeToRemove)
                    head = nodeToRemove.Next;
                else if (tail == nodeToRemove)
                    tail = tail.Previous;

                Length--;
                return true;
            }
            return false;
        }

        public DoubleNode FindNodeByValue(int nodeData)
        {
            if (!IsEmpty())
            {
                DoubleNode? result = head;
                while (result is not null)
                {
                    if (result.Data == nodeData)
                    {
                        return result;
                    }
                    else
                    {
                        result = result.Next;
                    }
                }
            }

            return null;
        }

        public bool IsEmpty()
        {
            return !(Length > 0);
        }

        private void SetHeader(DoubleNode newNode)
        {
            head = newNode;
            head.Next = head;
            head.Previous = head;
            tail = head;
        }

        private void SetNodeAsHeader(DoubleNode newNode)
        {
            newNode.Next = head;
            newNode.Previous = tail;
            tail.Next = newNode;
            head.Previous = newNode;
            head = newNode;
        }
    }
}

