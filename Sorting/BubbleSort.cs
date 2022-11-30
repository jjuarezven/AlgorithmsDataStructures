using LinkedLists;

namespace Sorting
{
    internal static class BubbleSort
    {
        public static void Sort(SingleLinkedList list)
        {
            bool swapped;

            // length - 1 executions
            for (int i = 1; i < list.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < list.Length - i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        Common.Swap(list, j, j + 1);
                        swapped = true;
                    }
                }

                // optimization for stop processing when collection is ordered
                if (!swapped)
                {
                    break;
                }
            }

            Console.WriteLine("Ordered list:");
            list.Traverse();
        }
    }
}
