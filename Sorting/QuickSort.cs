using LinkedLists;

namespace Sorting
{
    internal static class QuickSort
    {
        public static void Sort(SingleLinkedList<int> list)
        {
            QuickSorts(list, 0, list.Length - 1);
            Console.WriteLine("Ordered list:");
            list.Traverse();
            Console.ReadLine();
        }

        private static void QuickSorts(SingleLinkedList<int> list, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return;
            }

            var pivotIndex = PartList(list, startIndex, endIndex);

            QuickSorts(list, startIndex, pivotIndex - 1);
            QuickSorts(list, pivotIndex + 1, endIndex);
        }

        private static int PartList(SingleLinkedList<int> list, int startIndex, int endIndex)
        {
            int pivot = 0, pivotIndex = 0, n = 0;

            pivot = list[endIndex];
            pivotIndex = startIndex;

            for (n = pivotIndex; n < endIndex; n++)
            {
                if (list[n] <= pivot)
                {
                    Common.Swap(list, n, pivotIndex);
                    pivotIndex++;
                }
            }
            Common.Swap(list, pivotIndex, endIndex);

            return pivotIndex;
        }
    }
}
