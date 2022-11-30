using Common;

namespace LinkedLists
{
    internal class SingleCircularLinkedList
    {
        private Node? head;
        private Node? tail;
        public int Length { get; private set; }

        public void AddAtStart(int nodeData)
        {
            var newNode = new Node
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
            var newNode = new Node
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
                newNode.Next = head;
                tail.Next = newNode;
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

            var newNode = new Node
            {
                Data = nodeData
            };

            if (position == 1)
            {
                SetNodeAsHeader(newNode);
            }
            else
            {
                var nodeToReplace = head;
                while (nodeToReplace is not null && position > 1)
                {
                    nodeToReplace = nodeToReplace.Next;
                    position--;
                }

                newNode.Next = nodeToReplace.Next;
                nodeToReplace.Next = newNode;
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

        public bool IsEmpty()
        {
            return !(Length > 0);
        }

        public bool DeleteNodeByValue(int nodeData)
        {
            if (!IsEmpty())
            {
                var index = GetNodeIndexByValue(nodeData);
                if (index > -1)
                {
                    // deleting the head node
                    if (index == 0)
                    {
                        head = head.Next;
                        tail.Next = head;
                    }
                    else
                    {
                        var nodeToDelete = FindNodeByValue(nodeData);
                        var previousNode = FindPrevious(nodeData);
                        // deleting the tail node
                        if (index == Length - 1)
                        {
                            tail = previousNode;
                            tail.Next = head;
                        }
                        // deleting any other node
                        else
                        {
                            previousNode.Next = nodeToDelete.Next;
                        }
                    }
                    Length--;
                }
            }
            return false;
        }

        private int GetNodeIndexByValue(int nodeData)
        {
            var index = -1;
            var node = head;
            for (int i = 0; i < Length; i++)
            {
                if (node.Data == nodeData)
                {
                    index = i;
                    break;
                }
                node = node.Next;
            }
            return index;
        }

        public Node FindNodeByValue(int nodeData)
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
                    if (node.Data == nodeData)
                    {
                        return node;
                    }
                    node = node.Next;
                }
            }

            return null;
        }

        public void Clear()
        {
            var current = head.Next;
            Node temp = null;
            while (current != head)
            {
                temp = current.Next;
                current = null;
                current = temp;
            }

            head = null;
            Length = 0;
        }

        private void SetNodeAsHeader(Node newNode)
        {
            // the new node needs to reference head as its Next
            newNode.Next = head;
            // new node now is the head
            head = newNode;
            // tail has to reference header as next node
            tail.Next = head;
        }

        public Node FindPrevious(int nodeData)
        {
            Node current = null;
            if (!IsEmpty())
            {
                current = head;

                while (current.Next.Data != nodeData)
                {
                    current = current.Next;
                }
            }
            return current;
        }
    }
}
