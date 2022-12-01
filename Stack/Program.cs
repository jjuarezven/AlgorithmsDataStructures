// See https://aka.ms/new-console-template for more information
using Stack;

var stack = new StackImplementation<int>();
Console.WriteLine("Stack using nodes");
stack.Push(4);
stack.Push(3);
stack.Push(2);
stack.Push(1);
stack.Traverse();
Console.WriteLine();
Console.WriteLine($"Pop: {stack.Pop()}");
Console.WriteLine($"Peek: {stack.Peek()}");
Console.WriteLine($"Count: {stack.Count}");
stack.Traverse();
Console.WriteLine($"Pop: {stack.Pop()}");
Console.WriteLine($"Pop: {stack.Pop()}");
Console.WriteLine($"Pop: {stack.Pop()}");

Console.WriteLine();
Console.WriteLine("Stack using linked list");
var stack2 = new StackImplementation<int>();
stack2.Push(4);
stack2.Push(3);
stack2.Push(2);
stack2.Push(1);
stack2.Traverse();
Console.WriteLine();
Console.WriteLine($"Pop: {stack2.Pop()}");
Console.WriteLine($"Peek: {stack2.Peek()}");
Console.WriteLine($"Count: {stack2.Count}");
stack2.Traverse();
Console.WriteLine($"Pop: {stack2.Pop()}");
Console.WriteLine($"Pop: {stack2.Pop()}");
Console.WriteLine($"Pop: {stack2.Pop()}");
Console.WriteLine($"Pop: {stack2.Pop()}");
