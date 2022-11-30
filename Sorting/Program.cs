using Common;
using LinkedLists;

namespace Sorting
{
    internal class Program
    {
        static readonly SingleLinkedList list = new SingleLinkedList();

        static Program()
        {
            list.AddAtEnd(5);
            list.AddAtEnd(29);
            list.AddAtEnd(8);
            list.AddAtEnd(13);

            list.AddAtEnd(19);
            list.AddAtEnd(17);
            list.AddAtEnd(11);
            list.AddAtEnd(1);
            list.AddAtEnd(80);
            list.AddAtEnd(55);
            Console.WriteLine("Unordered list:");
            foreach (Node item in list)
            {
                Console.WriteLine($"{item.Data}");
            }
            //list.Traverse();            
        }

        static void Main(string[] args)
        {
            //BubbleSort.Sort(list);
            //InsertionSort.Sort(list);
            //SelectionSort.Sort(list);
            //MergeSort.Sort(list);
            QuickSort.Sort(list);   
        }
    }
}