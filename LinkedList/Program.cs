namespace LinkedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single LinkedList

            Console.WriteLine("Creating and adding nodes to list");
            var list = new SingleLinkedList<int>();
            list.AddAtEnd(1);
            list.AddAtEnd(2);
            list.AddAtEnd(3);
            list.AddAtStart(25);

            Console.WriteLine("Traverse list");
            list.Traverse();

            Console.WriteLine("Search value inside list");
            var node = list.FindNodeByValue(2);
            if (node is not null)
            {
                Console.WriteLine(node.ToString());
            }
            else
            {
                Console.WriteLine("Data not found");
            }

            Console.WriteLine("Get node index by data");
            var index = list.FindNodeIndexByData(8);
            Console.WriteLine($"Index = {index}");

            Console.WriteLine("Find previous");
            Console.WriteLine(list.FindPrevious(9));

            Console.WriteLine("Delete node");
            list.DeleteNodeByValue(2);
            list.Traverse();

            Console.WriteLine("Insert node at position");
            list.AddAtIndex(1, 9);
            list.AddAtIndex(3, 50);
            list.Traverse();

            Console.WriteLine("Find node by index");
            var result = list.FindNodeByIndex(0);
            Console.WriteLine(result is null ? "No node" : result.Data);

            Console.WriteLine($"Using indexers: {list[1]}");
            list[1] = 100;
            Console.WriteLine($"Using indexers to set value: {list[1]}");
            list.Traverse();

            Console.WriteLine("Emptying and traverse list");
            list.Clear();
            list.Traverse();
            #endregion

            #region Simple Doubly linked list
            //var doublyCircularList = new DoublyLinkedList();
            //doublyCircularList.AddAtStart(3);
            //doublyCircularList.AddAtStart(2);
            //doublyCircularList.AddAtEnd(4);
            //doublyCircularList.AddAtPosition(1, 1);
            //doublyCircularList.AddAtEnd(5);
            //doublyCircularList.Traverse();

            //Console.WriteLine("Search value inside list");
            //var node = doublyCircularList.FindNodeByValue(2);
            //if (node is not null)
            //{
            //    Console.WriteLine(node.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}

            //Console.WriteLine("DeleteNodeByValue header node");
            //doublyCircularList.DeleteNodeByValue(1);
            //doublyCircularList.Traverse();

            //Console.WriteLine("DeleteNodeByValue tail node");
            //doublyCircularList.DeleteNodeByValue(5);
            //doublyCircularList.Traverse();

            //Console.WriteLine("DeleteNodeByValue any other node");
            //doublyCircularList.DeleteNodeByValue(3);
            //doublyCircularList.Traverse(); 

            //Console.WriteLine("Clear list");
            //doublyCircularList.Clear();
            //doublyCircularList.Traverse();
            #endregion

            #region Single Circular Linked List
            //var singleCircularList = new SingleCircularLinkedList();
            //singleCircularList.AddAtStart(3);
            //singleCircularList.AddAtStart(2);
            //singleCircularList.AddAtEnd(4);
            //singleCircularList.AddAtPosition(1, 1);
            //singleCircularList.AddAtEnd(5);
            //singleCircularList.Traverse();

            //Console.WriteLine("Search value inside list");
            //var node = singleCircularList.FindNodeByValue(2);
            //if (node is not null)
            //{
            //    Console.WriteLine(node.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}

            //Console.WriteLine("Delete header node");
            //singleCircularList.DeleteNodeByValue(1);
            //singleCircularList.Traverse();

            //Console.WriteLine("Delete tail node");
            //singleCircularList.DeleteNodeByValue(5);
            //singleCircularList.Traverse();

            //Console.WriteLine("Delete any other node");
            //singleCircularList.DeleteNodeByValue(3);
            //singleCircularList.Traverse();

            //Console.WriteLine("Clear list");
            //singleCircularList.Clear();
            //singleCircularList.Traverse();
            #endregion

            #region Doubly Circular Linked List
            //var doublyCircularList = new DoublyCircularLinkedList();
            //doublyCircularList.AddAtStart(3);
            //doublyCircularList.AddAtStart(2);
            //doublyCircularList.AddAtEnd(4);
            //doublyCircularList.AddAtPosition(1, 1);
            //doublyCircularList.AddAtEnd(5);
            //doublyCircularList.Traverse();

            //Console.WriteLine("Search value inside list");
            //var node = doublyCircularList.FindNodeByValue(2);
            //if (node is not null)
            //{
            //    Console.WriteLine(node.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("Data not found");
            //}

            //Console.WriteLine("DeleteNodeByValue header node");
            //doublyCircularList.DeleteNodeByValue(1);
            //doublyCircularList.Traverse();

            //Console.WriteLine("DeleteNodeByValue tail node");
            //doublyCircularList.DeleteNodeByValue(5);
            //doublyCircularList.Traverse();

            //Console.WriteLine("DeleteNodeByValue any other node");
            //doublyCircularList.DeleteNodeByValue(3);
            //doublyCircularList.Traverse();

            //Console.WriteLine("Clear list");
            //doublyCircularList.Clear();
            //doublyCircularList.Traverse(); 
            #endregion

            Console.ReadKey();
        }
    }
}