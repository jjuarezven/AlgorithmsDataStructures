// See https://aka.ms/new-console-template for more information
using Stack;

var stack = new StackImplementation();
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
Console.WriteLine($"Pop: {stack.Pop()}");
