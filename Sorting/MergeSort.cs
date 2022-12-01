using LinkedLists;

namespace Sorting
{
    internal static class MergeSort
    {
        public static void Sort(SingleLinkedList<int> list)
        {
            var orderedList = DivideList(list);
            Console.WriteLine("Ordered list:");
            orderedList.Traverse();
            Console.ReadLine();
        }

        private static SingleLinkedList<int> DivideList(SingleLinkedList<int> list)
        {
            int length = list.Length;
            if (length < 2)
            {
                return list;
            }

            int middle = length / 2;
            var left = new SingleLinkedList<int>();
            var right = new SingleLinkedList<int>();

            for (var i = 0; i < middle; i++)
            {
                left.AddAtEnd(list[i]);
            }

            for (var i = middle; i < length; i++)
            {
                right.AddAtEnd(list[i]);
            }

            var tempLeft = DivideList(left);
            var tempRight = DivideList(right);

            return Merge(tempLeft, tempRight);
        }

        private static SingleLinkedList<int> Merge(SingleLinkedList<int> left, SingleLinkedList<int> right)
        {
            var mergedList = new SingleLinkedList<int>();
            var leftIndex = 0;
            var rightIndex = 0;

            var leftLength = left.Length;
            var rightLength = right.Length;

            // iterate while both list has items
            while (leftIndex < leftLength && rightIndex < rightLength)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    mergedList.AddAtEnd(left[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    mergedList.AddAtEnd(right[rightIndex]);
                    rightIndex++;
                }
            }

            while (leftIndex < leftLength)
            {
                mergedList.AddAtEnd(left[leftIndex]);
                leftIndex++;
            }

            while (rightIndex < rightLength)
            {
                mergedList.AddAtEnd(right[rightIndex]);
                rightIndex++;
            }
            //Console.WriteLine();
            //mergedList.Traverse();
            return mergedList;
        }
    }
}
