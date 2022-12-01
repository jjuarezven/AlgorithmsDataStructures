using System.Collections;
using Common;

namespace LinkedLists
{
    public class SingleLinkedList : IEnumerable
    {
        private Node head;
        private Node current;
        public int Length { get; private set; }

        public SingleLinkedList()
        {
            head = new Node();
        }

        public int this[int index]
        {
            get
            {
                var result = -1;
                current = FindNodeByIndex(index);
                if (current is not null)
                {
                    result = current.Data;
                }
                return result;
            }
            set
            {
                current = FindNodeByIndex(index);
                if (current is not null)
                {
                    current.Data = value;
                }
            }
        }

        public void Traverse()
        {
            current = head;
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty");
            }
            else
            {
                while (current.Next is not null)
                {
                    current = current.Next;
                    var nodeInfo = current.Data;
                    Console.WriteLine($"{nodeInfo}");
                }
            }
        }

        public void AddAtEnd(int nodeData)
        {
            // traverse the list to get the last node
            current = head;
            while (current.Next is not null)
            {
                current = current.Next;
            }

            // create a new node and set info
            var newNode = new Node
            {
                Data = nodeData
            };

            // set the newNode reference to the last node
            current.Next = newNode;
            Length++;
        }

        public void AddAtStart(int nodeData)
        {
            // create a new node and set info
            var newNode = new Node
            {
                Data = nodeData,
                Next = head.Next
            };

            // set the newNode reference to the head node
            head.Next = newNode;
            Length++;
        }

        public void AddAfter(int nodeDataPosition, int nodeData)
        {
            current = Find(nodeDataPosition);
            if (current is not null)
            {
                AddNodeDinamically(nodeData);
            }
            Length++;
        }

        public void AddBefore(int nodeDataPosition, int nodeData)
        {
            current = FindPrevious(nodeDataPosition);
            if (current is not null)
            {
                AddNodeDinamically(nodeData);
            }
            Length++;
        }

        public void Clear()
        {
            // garbage colector reclaims unused memory
            head.Next = null;
            Length = 0;
        }

        public bool IsEmpty()
        {
            return head.Next is null;
        }

        public Node Find(int nodeData)
        {
            Node? result = null;

            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null)
                {
                    current = current.Next;
                    if (current.Data == nodeData)
                    {
                        result = current;
                        break;
                    }
                }
            }

            return result;
        }

        public int FindNodeIndexByData(int nodeData)
        {
            var index = -1;

            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null)
                {
                    current = current.Next;
                    index++;
                    if (current.Data == nodeData)
                    {
                        return index;
                    }
                }
            }

            return index;
        }

        public Node FindNodeByIndex(int nodeIndex)
        {
            Node? node = null;
            var index = -1;

            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null)
                {
                    current = current.Next;
                    index++;
                    if (index == nodeIndex)
                    {
                        node = current;
                        break;
                    }
                }
            }

            return node;
        }

        // Finds the previous node, if nodeIndex is in the first node returns head node
        // if nodeIndex is not found returns last node
        public Node FindPrevious(int nodeData)
        {
            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null && current.Next.Data != nodeData)
                {
                    current = current.Next;
                }
            }
            return current;
        }

        public void Delete(int nodeData)
        {
            if (!IsEmpty())
            {
                var previous = FindPrevious(nodeData);
                var found = Find(nodeData);
                if (found is not null)
                {
                    // links the next node of the found node to its previous so the reference to found.Next is preserved
                    previous.Next = found.Next;
                    found.Next = null;
                }
            }
        }

        private void AddNodeDinamically(int nodeData)
        {
            var newNode = new Node
            {
                Data = nodeData,
                Next = current.Next
            };
            current.Next = newNode;
        }

        public IEnumerator GetEnumerator()
        {
            current = head.Next;
            while (current is not null) 
            {
                yield return current;
                current = current.Next;
            }
        }
    }
}
