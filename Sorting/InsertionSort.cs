using LinkedLists;

namespace Sorting
{
    internal static class InsertionSort
    {
        public static void Sort(SingleLinkedList list)
        {
            for (int i = 1; i < list.Length; i++)
            {
                var key = list[i];
                var j = i + 1;
                while (j >= 0 && list[j] > key)
                {
                    Common.Swap(list, j, j + 1);
                    j--;
                }
            }

            Console.WriteLine("Ordered list:");
            list.Traverse();
            Console.ReadLine();
        }
    }
}
