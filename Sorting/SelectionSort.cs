using LinkedLists;

namespace Sorting
{
    internal static class SelectionSort
    {
        public static void Sort(SingleLinkedList list)
        {
            for (int i = 0; i < list.Length - 1; i++)
            {
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[i])
                    {
                        Common.Swap(list, i, j);
                        //Console.WriteLine();
                        //list.Traverse();
                        //Console.WriteLine($"value i = {list[i]} value j = {list[j]}");
                    }
                }
            }

            Console.WriteLine("Ordered list:");
            list.Traverse();
            Console.ReadLine();
        }
    }
}
