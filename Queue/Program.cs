// See https://aka.ms/new-console-template for more information
using Queue;

var queue = new QueueImplementation<int>();
Console.WriteLine("Queue using nodes");
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Traverse();
Console.WriteLine();
Console.WriteLine($"Dequeue: {queue.Dequeue()}");
Console.WriteLine($"Peek: {queue.Peek()}");
Console.WriteLine($"Count: {queue.Count}");
queue.Traverse();
Console.WriteLine($"Dequeue: {queue.Dequeue()}");
Console.WriteLine($"Dequeue: {queue.Dequeue()}");
Console.WriteLine($"Dequeue: {queue.Dequeue()}");
Console.WriteLine($"Count: {queue.Count}");


