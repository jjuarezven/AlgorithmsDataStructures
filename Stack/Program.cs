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
var stack2 = new StackWithLinkedList<int>();
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

Console.ReadKey();
Console.Clear();
Console.WriteLine($"Symbol balance exercise{Environment.NewLine}Please indicate expression:");
string expression = Console.ReadLine();
ValidateSymbols(expression);

void ValidateSymbols(string? expression)
{
	var charStack = new StackImplementation<char>();
	var openingSymbols = new char[] {'(','{','[' };
    var closingSymbols = new char[] { ')', '}', ']' };

    foreach (char item in expression)
	{
		if (openingSymbols.Contains(item))
		{
			charStack.Push(item);		
		}

        if (closingSymbols.Contains(item))
        {
			if (charStack.IsEmpty())
			{
				Console.WriteLine("Too much closing symbols"); 
			}
			else 
			{ 
				var symbol = charStack.Pop();
				var openingIndex = Array.IndexOf(openingSymbols, symbol);
                var closingIndex = Array.IndexOf(closingSymbols, item);
                if (openingIndex != closingIndex) 
				{
                    Console.WriteLine($"Error: {closingSymbols[openingIndex]} expected");
                }
			}
        }
    }

	if (!charStack.IsEmpty())
	{
        Console.WriteLine("Too much opening symbols");
    }
}