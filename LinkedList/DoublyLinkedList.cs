namespace LinkedLists
{
    internal class DoublyLinkedList
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
                head = newNode;
                tail = head;
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
                head = newNode;
                tail = head;
            }
            else
            {
                // the new node needs to reference tail as its Previous
                newNode.Previous = tail;
                // tail needs to add the new node as its Next
                tail.Next = newNode;
                // new node is now the tail
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
                while (node is not null)
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

        public bool Delete(int value)
        {
            var node = FindNodeByValue(value);
            if (node is not null)
            {
                if (node.Previous is not null)
                {
                    node.Previous.Next = node.Next;
                }
                else
                {
                    head = node.Next;
                }

                if (node.Next is not null)
                {
                    node.Next.Previous = node.Previous;
                }
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

        private void SetNodeAsHeader(DoubleNode newNode)
        {
            // the new node needs to reference head as its Next
            newNode.Next = head;
            // head needs to add the new node as its Previous
            head.Previous = newNode;
            // new node now is the head
            head = newNode;
        }
    }
}
