using LinkedLists;

namespace Sorting
{
    internal static class Common
    {
        public static void Swap(SingleLinkedList list, int index1, int index2)
        {
            var temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}
