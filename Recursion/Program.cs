string algo = "";
var exit = "";
while (exit != "x")
{
    Console.Clear();


    //Console.Write("Please indicate the number to calculate factorial: ");
    //var number = int.Parse(Console.ReadLine()!);
    //Console.WriteLine($"{number}! = {Factorial(number)}");

    //Console.Write("Please indicate the number to calculate Fibonacci: ");
    //var number = int.Parse(Console.ReadLine());
    //int[] result = new int[number+1];
    //Console.WriteLine($"First {number} numbers in Fibonacci {Fibonacci(number)}");
    //Console.Write(String.Join(",", result));

    //Console.Write("Please indicate the base number: ");
    //var baseNumber = int.Parse(Console.ReadLine()!);
    //Console.Write("Please indicate the exponent number: ");
    //var exponentNumber = int.Parse(Console.ReadLine()!);
    //Console.WriteLine($"{baseNumber} ^ {exponentNumber} = {CalculatePower(baseNumber, exponentNumber)}"); 

    //Console.Write("Please indicate the first number to multiply: ");
    //var firstNumber = int.Parse(Console.ReadLine()!);
    //Console.Write("Please indicate the second number to multiply: ");
    //var secondNumber = int.Parse(Console.ReadLine()!);
    //Console.WriteLine($"{firstNumber} * {secondNumber} = {Multiply(firstNumber, secondNumber)}");

    //Console.Write("Please indicate the string: ");
    //var word = Console.ReadLine()!;
    //Console.WriteLine($"Result = {InvertString(word)}");

    Console.Write("Please indicate the string: ");
    var word = Console.ReadLine()!;
    Console.WriteLine($"Result = {IsPalindrome(word.ToLower())}");


    Console.Write("Press x to exit => ");
    exit = Console.ReadLine()!.ToLower();
}

bool IsPalindrome(string word)
{
    bool result = false;
    if (word.Length == 1)
    {
        result = true;
    }
    else
    {
        var lastChar = word[word.Length - 1];
        var firstChar = word[0];
        var areEqual = lastChar == firstChar;
        if (word.Length - 2 <= 0 && areEqual)
            result = true;
        else
        {
            word = word.Substring(1, word.Length - 2);
            result = areEqual && IsPalindrome(word);
        }
    }
    return result;
}

string InvertString(string word)
{
    var result = "";
    if (word.Length >= 1)
    {
        var lastChar = word[^1];
        word = word.Substring(0, word.Length - 1);
        result = lastChar + InvertString(word);
    }
    return result;
}


int Multiply(int firstNumber, int secondNumber)
{
    var result = 0;
    if (secondNumber > result)
    {
        result = firstNumber + Multiply(firstNumber, secondNumber - 1);
    }

    return result;
}

int CalculatePower(int baseNumber, int exponentNumber)
{
    var power = 0;
    if (exponentNumber == 1)
    {
        power = baseNumber;
    }
    else
    {
        power = baseNumber * CalculatePower(baseNumber, exponentNumber - 1);
    }
    return power;
}

int Fibonacci(int number)
{
    var result = 0;
    if (number < 2)
    {
        result = 1;
    }
    if (number > result)
    {
        result = Fibonacci(number - 1) + Fibonacci(number - 2);
    }
    //result[number] = r;
    return result;
}

int Factorial(int number)
{
    var result = 1;
    if (number > result)
    {
        result = number * Factorial(number - 1);
    }

    return result;
}