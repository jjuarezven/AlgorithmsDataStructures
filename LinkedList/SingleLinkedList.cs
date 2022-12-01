using System.Collections;
using Common;

namespace LinkedLists
{
    public class SingleLinkedList<T> : IEnumerable
    {
        private Node<T> head;
        private Node<T> current;
        public int Length { get; private set; }

        public SingleLinkedList()
        {
            head = new Node<T>();
        }

        public T this[int index]
        {
            get
            {
                T? result = default;
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

        public void AddAtEnd(T nodeData)
        {
            // traverse the list to get the last node
            current = head;
            while (current.Next is not null)
            {
                current = current.Next;
            }

            // create a new node and set info
            var newNode = new Node<T>
            {
                Data = nodeData
            };

            // set the newNode reference to the last node
            current.Next = newNode;
            Length++;
        }

        public void AddAtStart(T nodeData)
        {
            // create a new node and set info
            var newNode = new Node<T>
            {
                Data = nodeData,
                Next = head.Next
            };

            // set the newNode reference to the head node
            head.Next = newNode;
            Length++;
        }

        public void AddAtIndex(int index, T nodeData)
        {
            if (index > Length || index < 0)
                throw new ArgumentOutOfRangeException();
            if (index == 1)
                AddAtStart(nodeData);
            // Length - 2 because head stores no data in this implementation
            else if (index == Length)
                AddAtEnd(nodeData);
            else
            {
                current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                var newNode = new Node<T>
                {
                    Data = nodeData,
                    Next = current.Next
                };
                current.Next = newNode;
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

        public Node<T> FindNodeByValue(T nodeData)
        {
            Node<T>? result = null;

            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null)
                {
                    current = current.Next;
                    if (current.Data.Equals(nodeData))
                    {
                        result = current;
                        break;
                    }
                }
            }

            return result;
        }

        public int FindNodeIndexByData(T nodeData)
        {
            var index = -1;

            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null)
                {
                    current = current.Next;
                    index++;
                    if (current.Data.Equals(nodeData))
                    {
                        return index;
                    }
                }
            }

            return index;
        }

        public Node<T> FindNodeByIndex(int nodeIndex)
        {
            Node<T>? node = null;
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
        public Node<T> FindPrevious(T nodeData)
        {
            if (!IsEmpty())
            {
                current = head;

                while (current.Next is not null && !current.Next.Data.Equals(nodeData))
                {
                    current = current.Next;
                }
            }
            return current;
        }

        public void DeleteNodeByValue(T nodeData)
        {
            if (!IsEmpty())
            {
                var previous = FindPrevious(nodeData);
                var found = FindNodeByValue(nodeData);
                if (found is not null)
                {
                    // links the next node of the found node to its previous so the reference to found.Next is preserved
                    previous.Next = found.Next;
                    found.Next = null;
                }
                Length--;
            }
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
