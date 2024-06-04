// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Calculator");
Console.WriteLine("First Number: ");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Second Number: ");
var num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose Operation: Add, Subtract, Multiplication, Division, Remainder, Exponent, Exit");
var action = Console.ReadLine();
switch (action)
{
    case "Add":
        Console.WriteLine(num1 + num2);
        break;
    case "Subtract":
        Console.WriteLine(num1 - num2);
        break;
    case "Multiplication":
        Console.WriteLine(num1 * num2);
        break;
    case "Division":
        if (num1 != 0 || num2 != 0)
            Console.WriteLine(num1 / num2);
        else
            Console.WriteLine("Division cannot take place with a zero.");
        break;
    case "Remainder":
        if (num1 > num2)
            Console.WriteLine(num1 % num2);
        else Console.WriteLine("Can't Implement");
        break;
    case "Exponent":
        var result = 1;
        for (int i = 0; i < num2; i++)
        {
            result = result * num1;
        }
        Console.WriteLine(result);
        break;
    case "Exit":
        break;
}


